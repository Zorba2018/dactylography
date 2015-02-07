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
        public Form1()
        {
            InitializeComponent();

            string txt = "qwertzuiopšđasdfghjklčćžyxcvbnm".ToUpper();

            text1.Txt = txt;
            keyboard1.fingerKey = keyboard1.getKey(txt.ElementAt(0).ToString());
            keyboard1.getKey(txt.ElementAt(0).ToString()).BackColor = Color.Red;

            text1.printText();

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
                key.BackColor = SystemColors.Control;
                key.UseVisualStyleBackColor = true;
                String current = text1.keyPressed(key.Text);
                if (current != null)
                {
                    if (current.CompareTo("DONE") == 0)
                    {
                        keyboard1.fingerKey = null;
                        keyboard1.Invalidate();
                        // zelim da se prije izbrise sve pa da ispisem poruku.
                        MessageBox.Show("Svaka čast!");
                    }
                    else
                    {
                        keyboard1.fingerKey = keyboard1.getKey(current);
                        keyboard1.getKey(current).BackColor = Color.Red;
                        keyboard1.Invalidate();
                    }
                }
            }
        }

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


    }
}
