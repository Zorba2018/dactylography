using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;


namespace Dactylography
{
    public partial class Form1 : Form
    {
        //for statistics
        public Exercise exercise;
        public string filePath;
        public int timePassed = 0;

        private bool previewKey;
        public bool PreviewKey
        {
            get { return previewKey; }
            set { previewKey = value; RefreshForm(); }
        }

        private bool previewFinger;
        public bool PreviewFinger
        {
            get { return previewFinger; }
            set { previewFinger = value; RefreshForm(); }
        }

        private bool wait;
        public bool Wait
        {
            get { return wait; }
            set { wait = value; RefreshForm(); }
        }

        public Form1()
        {
            InitializeComponent();

            previewKey = Properties.Settings.Default.previewKey;
            previewFinger = Properties.Settings.Default.previewFinger;
            wait = Properties.Settings.Default.wait;

            exercise = new Exercise();

            toolStrip1.ShowItemToolTips = false;
        }

        public void startExercise()
        {
            timer1.Enabled = true;

        }

        public void stopExercise()
        {
            timer1.Enabled = false;

        }

        public void setText(string txt)
        {
            if (text1.Txt != null)
            {
                ClearForm();
            }
            text1.Txt = txt;
            RefreshForm();
        }

        public void ClearForm()
        {
            // mice oznaku iduce tipke
            keyboard1.getKey(text1.current()).BackColor = SystemColors.Control;
            keyboard1.getKey(text1.current()).UseVisualStyleBackColor = true;
            // mice oznaku prsta
            keyboard1.FingerKey = null;
        }

        /* Sluzi za "refreshanje" forme u smislu da se ucitaju potencijalno nove postavke
           i da se sukladno njima forma promijeni. */
        public void RefreshForm()
        {
            // ne radi kad nije inicijalizirano, a postavke se promjene
            // zelimo li vidjeti iducu tipku
            if (keyboard1.getKey(text1.current()) == null) { return; } // ako je sve nula, ingoriraj
            // koristim zato što se postavke mogu mijenjati i kad nije inicijalizirano
            else if (PreviewKey)
            {
                keyboard1.getKey(text1.current()).BackColor = Color.LightBlue;
            }
            else
            {
                keyboard1.getKey(text1.current()).BackColor = SystemColors.Control;
                keyboard1.getKey(text1.current()).UseVisualStyleBackColor = true;
            }

            // zelimo li vidjeti iduci prst
            if (previewFinger)
            {
                keyboard1.FingerKey = keyboard1.getKey(text1.current()).finger;
            }
            else
            {
                keyboard1.FingerKey = null;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (text1.Txt != null)
            {
                Key key = keyboard1.getKey(keyCodeToString(e));
                if (key != null)
                {
                    key.BackColor = Color.DarkGray;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (text1.Txt != null)
            {
                Key key = keyboard1.getKey(keyCodeToString(e));
                if (key != null)
                {
                    // ovako je napisano da mogu pozvati istu metodu kasnije
                    // vidi dolje
                    keyUp(key, false);
                }
            }
        }

        /* key - tipka koja je stisnuta
         * fake - true ako "simuliramo", false ako je korisnik stvarno stisnuo tipku
         * 
         * "simulirati" cemo onda kada korisnik ne zeli cekati na krivo pritisnutu tipku - u tom slucaju
         * cemo mi "pritisnuti" pravu tipku a efektive ce se sve pomaknuti na iduce slovo
         */

        // kako je trenutno napravljeno, ne možemo označiti slova koja su krivo pritisnuta
        // želimo li to uopće?

        private void keyUp(Key key, bool fake)
        {
             // vracanje u defaultnu boju ako ne prelazimo preko tipke
            key.BackColor = SystemColors.Control;            
            key.UseVisualStyleBackColor = true;

            String status = text1.keyPressed(key.Text, fake); //tu treba slati fake
            if (status.CompareTo("DONE") == 0)
            {
                if (!fake) exercise.lastScore.correct++;

                keyboard1.FingerKey = null;
                MessageBox.Show("Svaka čast!");
                

               
                //TODO preprepared exercises
                //TODO wpm calculation
                if (filePath != null) //if the file wasn't just randomly generated
                {
                    exercise.updateBest();

                    string json = new JavaScriptSerializer().Serialize(exercise);
                    try
                    {
                        System.IO.File.WriteAllText(filePath, json);
                    }
                    catch
                    {
                        MessageBox.Show("The exercise result couldn't be saved!");
                    }
                    filePath = null;
                }

            }
            else if (status.CompareTo("WRONG") == 0)
            {
                if (!fake) exercise.lastScore.wrong++;
                if (Wait == false)
                {
                    // simuliranje pritiska "prave tipke"
                    keyUp(keyboard1.getKey(text1.current()), true);
                }
            }
            else
            {
                if (!fake) exercise.lastScore.correct++;

                if (previewFinger)
                {
                    keyboard1.FingerKey = keyboard1.getKey(status).finger;
                }
                if (PreviewKey)
                {
                    keyboard1.getKey(status).BackColor = Color.LightBlue;
                }
            }
        }

        /* Pretvara KeyCode u String */
        private string keyCodeToString(KeyEventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            string s = kc.ConvertToString(e.KeyCode);

            switch (s)
            {
                case "Oem1": return "Č";
                case "Oem7": return "Ć";
                case "Oem5": return "Ž";
                case "OemOpenBrackets": return "Š";
                case "Oem6": return "Đ";
                case "Space": return " ";
                default: return s;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void createExerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateExer f = new FormCreateExer(this);
            f.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings f = new FormSettings(this);
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text1.Location = new Point(0, keyboard1.Location.Y + keyboard1.Size.Height);
            text1.Height = ClientSize.Height - text1.Location.Y;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            text1.Height = ClientSize.Height - text1.Location.Y;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON Files (.json)|*.json|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string json = System.IO.File.ReadAllText(path);
                exercise = (Exercise) new JavaScriptSerializer().Deserialize(json, typeof(Exercise));

                //test
                setText(exercise.text);
            }

        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(exercise.printFormatted(), "Statike trenutne vježbe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timePassed++;
            timerLabel.Text = timePassed.ToString();
        }


    }
}
