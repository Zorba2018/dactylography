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

        private string text;

        Font font = new Font(FontFamily.GenericMonospace, 16.0f, FontStyle.Bold);
        Font underlined_font = new Font(FontFamily.GenericMonospace, 16.0f, FontStyle.Bold | FontStyle.Underline);

        public string Txt
        {
            get { return text; }
            set
            {
                if (value == null)
                {
                    return;
                }
                text = value.ToUpper();
                words[0] = new StringBuilder();
                words[1] = new StringBuilder();
                words[2] = new StringBuilder(text);

                words[1].Append(words[2][0]);
                words[2].Remove(0, 1);
            }
        }

        private StringBuilder[] words = new StringBuilder[3];
        private Color[] colors = 
        {
		    Color.LightGray,
		    Color.Black,
		    Color.DarkGray
	    };
	    
        public Text()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public string keyPressed(string key)
        {
            if (words[1].Length == 1 && key.CompareTo(words[1].ToString()) == 0)
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
            return null;
        }

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
