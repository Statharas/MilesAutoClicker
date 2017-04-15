using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class LeftClick : Sequence
    {
        public LeftClick(int per, Mouse.MousePoint loc, bool nostop = false)
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
}
