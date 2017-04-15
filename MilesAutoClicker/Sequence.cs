using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
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
}
