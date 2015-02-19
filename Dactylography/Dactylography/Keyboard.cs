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
    public partial class Keyboard : UserControl
    {

        private Dictionary<string, Key> keys = new Dictionary<string, Key>();

        private string[][] alphabet = new string[4][];

        private int keys_size = 27;
        private int keys_spacing = 2;
        private int[] keys_x_starts = { 190, 197, 212, 267 };
        private int[] keys_y_starts = { 33, 62, 91, 120 };

        private int mark_radius = 10;
        
        private Finger fingerKey;
        public Finger FingerKey
        { 
            get { return fingerKey; }
            set { fingerKey = value; this.Invalidate(); }
        }

        public Keyboard()
        {
            InitializeComponent();

            alphabet[0] = new string[] { "Q", "W", "E", "R", "T", "Z", "U", "I", "O", "P", "Š", "Đ", "Ž" };
            alphabet[1] = new string[] { "A", "S", "D", "F", "G", "H", "J", "K", "L", "Č", "Ć"  };
            alphabet[2] = new string[] { "Y", "X", "C", "V", "B", "N", "M" };
            alphabet[3] = new string[] { " " };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < alphabet[i].Length; j++)
                {
                    Key key = new Key(getFinger(i, j));
                    key.Text = alphabet[i][j];
                    key.Location = new Point(keys_x_starts[i] + (keys_size + keys_spacing) * j,
                        keys_y_starts[i]);
                    if (key.Text.CompareTo("Ž") == 0)
                    {
                        key.Size = new Size(44, keys_size);
                    }
                    else if (key.Text.CompareTo(" ") == 0)
                    {
                        key.Size = new Size(161, keys_size);
                    }
                    else
                    {
                        key.Size = new Size(keys_size, keys_size);
                    }
                    keys[alphabet[i][j]] = key;
                }
            }

            this.Controls.AddRange(keys.Values.ToArray());
        }

        // i = row, j = column
        private Finger getFinger(int i, int j)
        {
            if (i == 3)
            {
                // space
                return new Finger(1, Finger.Hand.Left);
            }
            Finger.Hand hand = (j <= 4 ? Finger.Hand.Left : Finger.Hand.Right);
            int digit;
            if (hand == Finger.Hand.Left)
            {
                digit = (j < 4 ? 4 - j + 1 : 2);
            }
            else
            {
                if (j <= 6)
                {
                    digit = 2;
                }
                else if (j >= 10)
                {
                    digit = 5;
                }
                else
                {
                    digit = j - 4;
                }
            }
            return new Finger(digit, hand);
        }

        public Key getKey(string key)
        {
            if (keys == null || key == null) return null; //mogu li keys biti null?
            else if (keys.ContainsKey(key))
            {
                return keys[key];
            }
            else return null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (fingerKey != null)
            {
                System.Drawing.Graphics graphicsObj = this.CreateGraphics();
                Rectangle myRectangle = new Rectangle(fingerKey.Point.X - mark_radius, fingerKey.Point.Y - mark_radius, 2 * mark_radius, 2 * mark_radius);
                graphicsObj.DrawEllipse(new Pen(System.Drawing.Color.Red, 2), myRectangle);
            }
        }

    }
}
