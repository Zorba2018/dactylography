using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Dactylography
{
    public partial class FormCreateExer : Form
    {

        private Form1 f;

        public FormCreateExer(Form1 f)
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

            StringBuilder sb = new StringBuilder(excLength);
            Random rnd = new Random();

            int wordLength;
            while (true)
            {
                if (sb.Length >= excLength)
                {
                    break;
                }
                
                // odredi duljinu iduce rijeci
                wordLength = rnd.Next(minWordLength, maxWordLength + 1);

                for (int i = 0; i < wordLength; i++)
                {
                    sb.Append(letters.ElementAt(rnd.Next(0, letters.Count)));
                }

                // ako nisi dosao do kraja stavi razmak za iducu rijec
                if (sb.Length < excLength - 1)
                {
                    sb.Append(" ");
                }
            }

            f.exercise = new Exercise();
            f.exercise.highScore = new Statistics(1);
            f.exercise.lastScore = new Statistics(1);
            f.exercise.text = sb.ToString();

            if (save)
            {

                string json = new JavaScriptSerializer().Serialize(f.exercise);
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JSON File|*.json";
                saveFileDialog1.Title = "Save the generated exercise";
                DialogResult userClickedOK = saveFileDialog1.ShowDialog();

                if (userClickedOK == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
                        f.filePath = saveFileDialog1.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("The exercise couldn't be saved!");
                    }
                }

            }

            f.setText(sb.ToString());

            this.Dispose();

        }
    }
}
