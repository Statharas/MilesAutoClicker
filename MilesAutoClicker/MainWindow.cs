using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        
        bool running = false;
        private LowLevelKeyboardListener _listener;
        public AutoClicker()
        {
            InitializeComponent();
            PanelSwitch();
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();
            Handler.a = SimpleStart;
            Handler.b = SimpleStop;
            SimpleTimer.Value = Properties.Settings.Default.SimpleTimer;
            SimpleRepeats.Value = Properties.Settings.Default.SimpleRepeats;
            SimpleNonstop.Checked = Properties.Settings.Default.SimpleNonStop;
            SimpleRepeat.Checked = !Properties.Settings.Default.SimpleNonStop;
            SimpleLeftClick.Checked = !Properties.Settings.Default.SimpleClick;
            SimpleRightClick.Checked = Properties.Settings.Default.SimpleClick;
            SimpleMouseLocation.Checked = Properties.Settings.Default.SimpleMouse;
            SimpleLocation.Checked = !Properties.Settings.Default.SimpleMouse;
            SimpleX.Value = Properties.Settings.Default.SimpleMouseX;
            SimpleY.Value = Properties.Settings.Default.SimpleMouseY;
        }
        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if (e.KeyPressed.ToString() == "F6"&&SimpleStart.Enabled)
            {
                SimpleStart.PerformClick();
            }
            else if (e.KeyPressed.ToString() == "F6"&&SimpleStop.Enabled)
            {
                SimpleStop.PerformClick();
            }
            else if (e.KeyPressed.ToString() == "F5")
            {
                SimpleStop.PerformClick();
                Application.Exit();
            }
        }
        private void PanelSwitch()
        {
            if (AdvancedMode.Checked)
            {
                AdvancedPanel.Visible = false;
                SimplePanel.Visible = true;
                AdvancedMode.Checked = false;
                AdvancedMode.Text = "Switch to Advanced";
                Properties.Settings.Default.Mode = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                AdvancedPanel.Visible = true;
                SimplePanel.Visible = false;
                AdvancedMode.Checked = true;
                AdvancedMode.Text = "Switch to Basic";
                Properties.Settings.Default.Mode = true;
                Properties.Settings.Default.Save();
            }
        }

    private void AdvAfter_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void SimpleRepeats_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleRepeats = (int)SimpleRepeats.Value;
            Properties.Settings.Default.Save();
        }

        private void AdvSave_Click(object sender, EventArgs e)
        {
            running = !running;
            Mouse.MousePoint Pos = Mouse.GetCursorPosition();
            while (running)
            {
                Mouse.MouseEvent(Mouse.MouseEventFlags.LeftDown);
            }
        }

        private void AdvNew_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SimpleMouseLoc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleMouse = true;
            Properties.Settings.Default.Save();
        }

        private void SimpleTimer_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleTimer = (int)SimpleTimer.Value;
            Properties.Settings.Default.Save();
        }

        private void AdvancedMode_Click(object sender, EventArgs e)
        {
            PanelSwitch();
        }

        private void SimpleStart_Click(object sender, EventArgs e)
        {
            int iter=0;
            Mouse.MousePoint loc;
            loc.X = 0;
            loc.Y = 0;
            int period = 0;
            bool nostop = false;
            if (!SimpleNonstop.Checked && SimpleRepeat.Checked)
            {
                iter = (int)SimpleRepeats.Value;
            }
            else if (SimpleNonstop.Checked && !SimpleRepeat.Checked)
            {
                nostop = true;
            }
            else { iter = 0;
                toolStripStatusLabel1.Text = "ERROR";
            }

            if (SimpleMouseLocation.Checked && !SimpleLocation.Checked)
            {
                loc.X = -1;
                loc.Y = -1;
            }
            period = (int)SimpleTimer.Value;
            
            int count = 0;
            do
            {
                if (SimpleLeftClick.Checked)
                {
                    LeftClick b = new LeftClick(period, loc, nostop);
                    Handler.AddSequence(b);
                }
                if (SimpleRightClick.Checked)
                {
                    RightClick b = new RightClick(period, loc, nostop);
                    Handler.AddSequence(b);
                }

                    count++;
            } while (count < iter);
            Handler.Start();
        }

        private void SimpleRepeat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleNonStop = false;
            Properties.Settings.Default.Save();
        }

        private void SimpleKeybind_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text+"1" ;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SimplePickLoc_Click(object sender, EventArgs e)
        {
            SimplePickLoc.Enabled = false;
            
        }

        private void AutoClicker_Load(object sender, EventArgs e)
        {

        }

        private void SimpleTimer_ValueChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleTimer=(int)SimpleTimer.Value;
            Properties.Settings.Default.Save();
        }

        private void SimpleStop_Click(object sender, EventArgs e)
        {
            Handler.Stop();
            Handler.Clear();
        }

        private void SimpleNonstop_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleNonStop = true;
            Properties.Settings.Default.Save();
        }

        private void SimpleLeftClick_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleClick = false;
            Properties.Settings.Default.Save();
        }

        private void SimpleRightClick_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleClick = true;
            Properties.Settings.Default.Save();
        }

        private void SimpleMouseLocation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SimpleLocation_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleMouse = false;
            Properties.Settings.Default.Save();
        }

        private void SimpleX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleMouseX = (int)SimpleX.Value;
            Properties.Settings.Default.Save();
        }

        private void SimpleY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SimpleMouseY = (int)SimpleY.Value;
            Properties.Settings.Default.Save();
        }
    }
    public class LowLevelKeyboardListener
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public event EventHandler<KeyPressedArgs> OnKeyPressed;

        private LowLevelKeyboardProc _proc;
        private IntPtr _hookID = IntPtr.Zero;

        public LowLevelKeyboardListener()
        {
            _proc = HookCallback;
        }

        public void HookKeyboard()
        {
            _hookID = SetHook(_proc);
        }

        public void UnHookKeyboard()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if (OnKeyPressed != null) { OnKeyPressed(this, new KeyPressedArgs(KeyInterop.KeyFromVirtualKey(vkCode))); }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
    }

    public class KeyPressedArgs : EventArgs
    {
        public Key KeyPressed { get; private set; }

        public KeyPressedArgs(Key key)
        {
            KeyPressed = key;
        }
        
    }
}
