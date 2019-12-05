using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankalah
{
    // rename me
    public class jnb29 : Player // class must be public
    {
        public jnb29(Position pos, int maxTimePerMove) // constructor must match this signature
            : base(pos, "jnb29", maxTimePerMove) // choose a string other than "MyPlayer"
        {
        }

        // adapt all code from your player class into this
        public override int chooseMove(Board b)
        {
            if (b.whoseMove() == Position.Top)
            {
                for (int i = 12; i >= 7; i--)               // try first go-again
                    if (b.stonesAt(i) == 13 - i) return i;
                for (int i = 12; i >= 7; i--)               // otherwise, first
                    if (b.stonesAt(i) > 0) return i;        // available move
            }
            else
            {
                for (int i = 5; i >= 0; i--)
                    if (b.stonesAt(i) == 6 - i) return i;
                for (int i = 5; i >= 0; i--)
                    if (b.stonesAt(i) > 0) return i;
            }
            return -1;		        // an illegal move if there aren't any legal ones
        }

        public override String getImage() { return "jnb29.jfif"; }

        public override string gloat()
        {
            return "I WIN! Humans still rule.";
        }



}