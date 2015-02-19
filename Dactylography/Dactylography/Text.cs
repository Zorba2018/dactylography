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
        private static Exercise exer = new Exercise();
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
		    Color.DarkGray
	    };

        public string Txt
        {
            get { return exer.text; }
            set
            {
                if (value == null)
                {
                    return;
                }
                exer.text = value.ToUpper();
                words[0] = new StringBuilder();
                words[1] = new StringBuilder();
                words[2] = new StringBuilder(exer.text);

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
            // TODO

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
            for (int i = 0; i < this.words.Length; i++)
            {
                StringBuilder word = this.words[i];
                Color color = this.colors[i];
                {
                    this.SelectionColor = color;
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
}
