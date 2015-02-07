using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylography
{
    public partial class FormCreateExc : Form
    {

        private Form1 f;

        public FormCreateExc(Form1 f)
        {
            InitializeComponent();
            this.f = f;

            this.CancelButton = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // stavio sam masked da se mozda onemoguci drugo osim slova, ali nisam se bas poigrao s tim
            string _letters = maskedTextBox1.Text.ToUpper();

            HashSet<string> letters = new HashSet<string>();
            foreach (char c in _letters.ToCharArray())
            {
                if ((Char.IsLetter(c) || c == 'Š' || c == 'Đ' || c == 'Č' || c == 'Ć' || c == 'Ž'))
                {
                    letters.Add(c.ToString());
                }
            }

            if (letters.Count == 0)
            {
                MessageBox.Show("Nema slova.");
                return;
            }
            
            int excLength = Int32.Parse(numericUpDown1.Value.ToString());

            int minWordLength = Int32.Parse(numericUpDown2.Value.ToString());
            int maxWordLength = Int32.Parse(numericUpDown3.Value.ToString());

            bool save = checkBox1.Checked;

            if (excLength < minWordLength)
            {
                MessageBox.Show("Duljina vježbe premala!");
                return;
            }

            if (minWordLength > maxWordLength)
            {
                MessageBox.Show("Minimum veći od maksimuma?!");
                return;
            }

            StringBuilder sb = new StringBuilder(excLength, excLength);
            Random rnd = new Random();

            int wordLength;
            while (true)
            {
                if (sb.Length == sb.MaxCapacity)
                {
                    break;
                }
                // ako je manje od minimalne duljine
                if (sb.MaxCapacity - sb.Length < minWordLength)
                {
                    // popuni s prazninama jer je premalo za rijec
                    // TODO mozda se ovo da nekako pametnije
                    for (int i = 0; i < sb.MaxCapacity - sb.Length; i++)
                    {
                        sb.Append(" ");
                    }
                    break;
                }
                
                // inace odredi duljinu iduce rijeci
                int max = Math.Min(maxWordLength, sb.MaxCapacity-sb.Length);
                wordLength = rnd.Next(minWordLength, max + 1);

                for (int i = 0; i < wordLength; i++)
                {
                    sb.Append(letters.ElementAt(rnd.Next(0, letters.Count)));
                }

                // ako nisi dosao do kraja stavi razmak za iducu rijec
                if (sb.Length < sb.MaxCapacity)
                {
                    sb.Append(" ");
                }
            }

            if (save)
            {
                // TODO save file
            }

            f.setText(sb.ToString());

            this.Dispose();

        }
    }
}
