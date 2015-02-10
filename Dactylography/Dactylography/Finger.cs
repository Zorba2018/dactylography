using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dactylography
{
    public class Finger
    {
        public enum Hand { Left, Right };

        internal int digit;

        internal Hand hand;

        public Finger(int digit, Hand hand)
        {
            this.digit = digit;
            this.hand = hand;
        }

        public Point Point
        {
            get 
            {
                return new Point(x(), y());
            }
        }

        private int x()
        {
            if (this.hand == Dactylography.Finger.Hand.Left)
            {
                switch (this.digit)
                {
                    case 1: return 113;
                    case 2: return 56;
                    case 3: return 35;
                    case 4: return 20;
                    case 5: return 13;
                    default: throw new Exception();
                }

            }
            else
            {
                switch (this.digit)
                {
                    case 1: return 612;
                    case 2: return 668;
                    case 3: return 689;
                    case 4: return 704;
                    case 5: return 712;
                    default: throw new Exception();
                }
            }
        }

        private int y()
        {
            if (this.hand == Finger.Hand.Left)
            {
                switch (this.digit)
                {
                    case 1: return 85;
                    case 2: return 40;
                    case 3: return 41;
                    case 4: return 60;
                    case 5: return 92;
                    default: throw new Exception();
                }

            }
            else
            {
                switch (this.digit)
                {
                    case 1: return 85;
                    case 2: return 40;
                    case 3: return 42;
                    case 4: return 60;
                    case 5: return 91;
                    default: throw new Exception();
                }
            }
        }

    }
}
