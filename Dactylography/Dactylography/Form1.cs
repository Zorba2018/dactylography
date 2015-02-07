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
    public partial class Form1 : Form
    {

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
        public bool Wait {
            get { return wait; }
            set { wait = value; RefreshForm(); } 
        }

        public Form1()
        {
            InitializeComponent();

            previewKey = true;
            previewFinger = true;
            wait = true;
        }

        public void setText(string txt)
        {
            text1.Txt = txt;
            RefreshForm();
        }

        /* Sluzi za "refreshanje" forme u smislu da se ucitaju potencijalno nove postavke
           i da se sukladno njima forma promijeni. */
        public void RefreshForm()
        {
            // zelimo li vidjeti iducu tipku
            if (PreviewKey)
            {
                keyboard1.getKey(text1.current()).BackColor = Color.Red;
            }
            else
            {
                keyboard1.getKey(text1.current()).BackColor = SystemColors.Control;
                keyboard1.getKey(text1.current()).UseVisualStyleBackColor = true;
            }

            // zelimo li vidjeti iduci prst
            if (previewFinger)
            {
                keyboard1.FingerKey = keyboard1.getKey(text1.current());
            }
            else
            {
                keyboard1.FingerKey = null;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Key key = keyboard1.getKey(keyCodeToString(e));
            if (key != null)
            {
                key.BackColor = Color.DarkGray;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Key key = keyboard1.getKey(keyCodeToString(e));
            if (key != null)
            {
                // ovako je napisano da mogu pozvati istu metodu kasnije
                // vidi dolje
                keyUp(key, false);
            }
        }

        /* key - tipka koja je stisnuta
         * fake - true ako "simuliramo", false ako je korisnik stvarno stisnuo tipku
         * 
         * "simulirati" cemo onda kada korisnik ne zeli cekati na krivo pritisnutu tipku - u tom slucaju
         * cemo mi "pritisnuti" pravu tipku a efektive ce se sve pomaknuti na iduce slovo
         */
        private void keyUp(Key key, bool fake)
        {
            // vracanje u defaultnu boju
            key.BackColor = SystemColors.Control;
            key.UseVisualStyleBackColor = true;

            String status = text1.keyPressed(key.Text, false);
            if (status.CompareTo("DONE") == 0)
            {
                keyboard1.FingerKey = null;
                MessageBox.Show("Svaka čast!"); 
                // TODO statistika
            }
            else if (status.CompareTo("WRONG") == 0)
            {
                if (Wait == false)
                {
                    // simuliranje pritiska "prave tipke"
                    keyUp(keyboard1.getKey(text1.current()), true);
                }
            }
            else
            {
                if (previewFinger)
                {
                    keyboard1.FingerKey = keyboard1.getKey(status);
                }
                if (PreviewKey)
                {
                    keyboard1.getKey(status).BackColor = Color.Red;
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

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void krairajVježbuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateExc f = new FormCreateExc(this);
            f.ShowDialog();
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings f = new FormSettings(this);
            f.ShowDialog();
        }
        

    }
}
