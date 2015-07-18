namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    /*
     *  Hotkey abstraction kindly modified from:
     *  https://bloggablea.wordpress.com/2007/05/01/global-hotkeys-with-net/
     */

    public class Hotkey : IMessageFilter
    {
        private const uint ErrorHotkeyAlreadyRegistered = 1409;
        private const int MaximumID = 0xBFFF;
        private const uint ModAlt = 0x1;
        private const uint ModControl = 0x2;
        private const uint ModShift = 0x4;
        private const uint ModWin = 0x8;
        private const uint WmHotkey = 0x312;
        private static int currentID;
        private bool alt;
        private bool control;

        [XmlIgnore]
        private int id;

        private Keys keyCode;

        [XmlIgnore]
        private bool registered;

        private bool shift;

        [XmlIgnore]
        private Control windowControl;

        private bool windows;

        public Hotkey()
            : this(Keys.None, false, false, false, false)
        {
        }

        public Hotkey(Keys keyCode, bool shift, bool control, bool alt, bool windows)
        {
            this.KeyCode = keyCode;
            this.Shift = shift;
            this.Control = control;
            this.Alt = alt;
            this.Windows = windows;

            Application.AddMessageFilter(this);
        }

        ~Hotkey()
        {
            if (this.Registered)
            {
                this.Unregister();
            }
        }

        public event HandledEventHandler Pressed;

        public bool Alt
        {
            get
            {
                return this.alt;
            }

            set
            {
                this.alt = value;
                this.Reregister();
            }
        }

        public bool Control
        {
            get
            {
                return this.control;
            }

            set
            {
                this.control = value;
                this.Reregister();
            }
        }

        public bool Empty
        {
            get
            {
                return this.keyCode == Keys.None;
            }
        }

        public Keys KeyCode
        {
            get
            {
                return this.keyCode;
            }

            set
            {
                this.keyCode = value;
                this.Reregister();
            }
        }

        public bool Registered
        {
            get
            {
                return this.registered;
            }
        }

        public bool Shift
        {
            get
            {
                return this.shift;
            }

            set
            {
                this.shift = value;
                this.Reregister();
            }
        }

        public bool Windows
        {
            get
            {
                return this.windows;
            }

            set
            {
                this.windows = value;
                this.Reregister();
            }
        }

        public bool GetCanRegister(Control controlToRegister)
        {
            try
            {
                if (!this.Register(controlToRegister))
                {
                    return false;
                }

                this.Unregister();
                return true;
            }
            catch (Win32Exception)
            {
                return false;
            }
            catch (NotSupportedException)
            {
                return false;
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg != Hotkey.WmHotkey)
            {
                return false;
            }

            if (this.registered && (m.WParam.ToInt32() == this.id))
            {
                return this.OnPressed();
            }
            else
            {
                return false;
            }
        }

        public bool Register(Control controlToRegister)
        {
            if (controlToRegister == null)
            {
                return false;
            }

            if (this.registered)
            {
                return true;
            }

            if (this.Empty)
            {
                throw new NotSupportedException("You cannot register an empty hotkey");
            }

            this.id = Hotkey.currentID;
            Hotkey.currentID = (Hotkey.currentID + 1) % Hotkey.MaximumID;

            uint modifiers = (this.Alt ? Hotkey.ModAlt : 0) | (this.Control ? Hotkey.ModControl : 0) |
                            (this.Shift ? Hotkey.ModShift : 0) | (this.Windows ? Hotkey.ModWin : 0);

            if (NativeMethods.RegisterHotKey(controlToRegister.Handle, this.id, modifiers, this.keyCode) == 0)
            {
                if (Marshal.GetLastWin32Error() == ErrorHotkeyAlreadyRegistered)
                {
                    return false;
                }
                else
                {
                    throw new Win32Exception();
                }
            }

            this.registered = true;
            this.windowControl = controlToRegister;

            return true;
        }

        public void RemoveHandler()
        {
            this.Pressed = null;
        }

        public void SetHandler(Action<WindowSizePosition> resizeTo, WindowSizePosition windowSizePosition)
        {
            this.Pressed = null;
            this.Pressed += delegate { resizeTo(windowSizePosition); };
        }

        public override string ToString()
        {
            List<string> keys = new List<string>();

            if (this.Control)
            {
                keys.Add("Ctrl");
            }

            if (this.Alt)
            {
                keys.Add("Alt");
            }

            if (this.Shift)
            {
                keys.Add("Shift");
            }

            //// TODO: bool windowsPressed = (Control.ModifierKeys | Keys.LWin) == keyEventArgs.Modifiers;

            if ((this.KeyCode != Keys.ShiftKey) &&
                (this.KeyCode != Keys.ControlKey) &&
                (this.KeyCode != Keys.Menu) &&
                (this.KeyCode != Keys.LWin) &&
                (this.KeyCode != Keys.RWin))
            {
                keys.Add(this.KeyCode.ToString());
            }

            return string.Join(" + ", keys.ToArray());
        }

        public void Unregister()
        {
            if (!this.registered)
            {
                return;
            }

            if (!this.windowControl.IsDisposed)
            {
                if (NativeMethods.UnregisterHotKey(this.windowControl.Handle, this.id) == 0)
                {
                    throw new Win32Exception();
                }
            }

            this.registered = false;
            this.windowControl = null;
        }

        private bool OnPressed()
        {
            HandledEventArgs handledEventArgs = new HandledEventArgs(false);
            if (this.Pressed != null)
            {
                this.Pressed(this, handledEventArgs);
            }

            return handledEventArgs.Handled;
        }

        private void Reregister()
        {
            if (!this.registered)
            {
                return;
            }

            Control currentWindowControl = this.windowControl;

            this.Unregister();
            this.Register(currentWindowControl);
        }
    }
}