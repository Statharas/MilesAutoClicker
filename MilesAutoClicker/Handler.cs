using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoClicker
{
    public static class Handler
    {
        public static Button a;
        public static Button b;
        private static List<Sequence> ExecuteOrder = new List<Sequence>();
        static Timer Clock;
        static Handler()
        {
            Clock = new Timer();
            Clock.Tick += new EventHandler(Tock);
            Clock.Interval = 1;
        }
        static void Tock(object sender, EventArgs a)
        {
            Sequence z = ExecuteOrder.ElementAt(0);
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
}