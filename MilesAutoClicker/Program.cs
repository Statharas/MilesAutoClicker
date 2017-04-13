using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new AutoClicker());
        }
    }
    public static class Handler
    {
        public static Button a;
        public static Button b;
        public static Form form;
        private static List<Sequence> ExecuteOrder=new List<Sequence>();
        static Timer Clock;
        static Handler()
        {
            Clock = new Timer();
            Clock.Tick += new EventHandler(Tock);
            Clock.Interval = 1;
        }
        static void Tock(object sender, EventArgs a)
        {
            Sequence z=ExecuteOrder.ElementAt(0);
            if (z.GetAfter() > 0)
            {
                z.SetAfter(z.GetAfter() - Clock.Interval);
            }
            else
            {
                z.Action();
                if (!z.NoStop)
                {
                    ExecuteOrder.RemoveAt(0);
                }
            }
            if (!ExecuteOrder.Any())
            {
                Stop();
            }

        }
        public static void AddSequence(Sequence a)
        {
            ExecuteOrder.Add(a);
        }
        public static void Start()
        {
            a.Enabled = false;
            b.Enabled = true;
            Clock.Start();
        }
        public static void Stop()
        {
            b.Enabled = false;
            a.Enabled = true;
            Clock.Stop();
        }
        public static void Clear()
        {
            ExecuteOrder.Clear();
        }

    }
    /// <summary>
    /// base class
    /// </summary>
    public class Sequence
    {
        public bool NoStop = false;
        private Mouse.MousePoint Location;
        private int after = 0;
        public void SetLocation(Mouse.MousePoint a)
        {
            Location = a;
        }
        public Mouse.MousePoint GetLocation()
        {
            return Location;
        }
        public void SetAfter(int a)
        {
            after = a;
        }
        public int GetAfter()
        {
            return after;
        }
        public virtual void Action() { }
    }
    public class LeftClick : Sequence
    {
        public LeftClick(int per,Mouse.MousePoint loc,bool nostop=false)
        {
            SetAfter(per);
            SetLocation(loc);
            NoStop = nostop;
        }
        public override void Action()
        {
            if (GetLocation().X == -1 && GetLocation().Y == -1)
            {
            }
            else
            {
                Mouse.SetCursorPosition(GetLocation().X, GetLocation().Y);
            }

                Mouse.MouseEvent(Mouse.MouseEventFlags.LeftDown);
            Mouse.MouseEvent(Mouse.MouseEventFlags.LeftUp);
        }
    }
    public class RightClick : Sequence
    {
        public RightClick(int per, Mouse.MousePoint loc, bool nostop = false)
        {
            SetAfter(per);
            SetLocation(loc);
            NoStop = nostop;
        }
        public override void Action()
        {
            if (GetLocation().X == -1 && GetLocation().Y == -1)
            {
            }
            else
            {
                Mouse.SetCursorPosition(GetLocation().X, GetLocation().Y);
            }

            Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
            Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
        }
    }
    public static class Mouse
    {

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }

        }
    }
}
