using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dactylography
{
    public struct Statistics
    {
        public int length;
        public int correct;
        public int wrong;
        public double wpm;

        
        /// <summary>
        /// a constructor with a bogus argument
        /// </summary>
        /// <param name="a">the bogus argument needed because I'm using structs</param>

        public Statistics(int a)
        {
            length = correct = 0;
            wpm = 0;
            wrong = -1;
            //wrong -1 means that this was never run
        }


        public string printFormatted()
        {
            StringBuilder sb = new StringBuilder("Točno pritisnutih tipki: ");
            sb.Append(correct);
            sb.Append("\nBroj riječi po minuti: ");
            sb.Append(wpm);
            sb.Append("\nBroj grešaka: ");
            sb.Append(wrong);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
