using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylography
{
    public partial class Text : RichTextBox
    {
        /* text koji terba natipkati */
        public Exercise exercise = new Exercise();
        //private string text;

        private Font font = new Font(FontFamily.GenericMonospace, 16.0f, FontStyle.Bold);
        private Font underlined_font = new Font(FontFamily.GenericMonospace, 16.0f, FontStyle.Bold | FontStyle.Underline);

        /* words[0] - pretipkani dio teksta
         * words[1] - slovo koje treba pritisniti
         * words[2] - dio teksta koji tek treba natipkati */
        private StringBuilder[] words = new StringBuilder[3];

        /* boje koje odgovaraju words arrayu */
        private Color[] colors = 
        {
		    Color.LightGray,
		    Color.Black,
		    Color.DarkGray,
            Color.LightCoral
	    };

        private HashSet<int> wrongIndices = new HashSet<int>();

        public string Txt
        {
            get { return exercise.text; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    return;
                }
                exercise.text = value.ToUpper();

                exercise.uniqueChars = new HashSet<String>();
                foreach (char c in exercise.text)
                {
                    exercise.uniqueChars.Add(c.ToString());
                }

                wrongIndices.Clear();

                words[0] = new StringBuilder();
                words[1] = new StringBuilder();
                words[2] = new StringBuilder(exercise.text);

                words[1].Append(words[2][0]);
                words[2].Remove(0, 1);
                printText();

            }
        }

        public Text()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public string keyPressed(string key, bool fake)
        {
            // ako je fake, onda ne broji u statistiku, tj onda nije korisnik stisnuo
            // nego je simulirano


            // ako je stisuta prava tipka
            if (words[1].Length == 1 && key.CompareTo(current()) == 0)
            {
                words[0].Append(words[1][0]);
                words[1].Clear();

                if (words[2].Length > 0)
                {
                    words[1].Append(words[2][0]);
                    words[2].Remove(0, 1);
                    printText();
                    return words[1].ToString();
                }
                else
                {
                    printText();
                    return "DONE";
                }
            }
            wrongIndices.Add(words[0].Length);
            return "WRONG";
        }

        public String current()
        {
            if (words[1] == null) return null;
            return words[1].ToString();
        }

        // Ispisuje tekst
        public void printText()
        {
            this.Clear();

            // previous word
            for (int j = 0; j < this.words[0].Length; j++)
            {
                this.SelectionColor = (wrongIndices.Contains(j) ? colors[3] : colors[0]);
                this.SelectionFont = font;
                this.AppendText(this.words[0][j].ToString());
            }

            // current and next word
            for (int i = 1; i < this.words.Length; i++)
            {
                StringBuilder word = this.words[i];
                this.SelectionColor = this.colors[i];
                if (i == 1)
                {
                    this.SelectionFont = underlined_font;
                }
                else
                {
                    this.SelectionFont = font;
                }
                this.AppendText(word.ToString());
            }
        }

    }
}
