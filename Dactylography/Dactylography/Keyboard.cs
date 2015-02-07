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
        private Key fingerKey;
    
        public Key FingerKey
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
                    Key.Hand hand = ( j<=4 ? Key.Hand.Left : Key.Hand.Right);
                    int finger;
                    if (hand == Key.Hand.Left)
                    {
                        finger = (j < 4 ? 4 - j + 1 : 2);
                    }
                    else
                    {
                        if (j <= 6)
                        {
                            finger = 2;
                        } else if (j >= 10)
                        {
                            finger = 5;   
                        } else 
                        {
                            finger = j-4;      
                        }
                    }



                    Key key = new Key(hand, finger);
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

        public Key getKey(string key)
        {
            if (keys.ContainsKey(key))
            {
                return keys[key];
            }
            return null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (fingerKey != null)
            {
                System.Drawing.Graphics graphicsObj = this.CreateGraphics();
                Pen myPen = new Pen(System.Drawing.Color.Red, 2);
                Rectangle myRectangle = new Rectangle(getX(fingerKey) - mark_radius, getY(fingerKey) - mark_radius, 2 * mark_radius, 2 * mark_radius);
                graphicsObj.DrawEllipse(myPen, myRectangle);
            }
        }

        int getX(Key key)
        {
            if (key.hand == Key.Hand.Left)
            {
                switch (key.finger)
                {
                    case 1: return 113;
                    case 2: return 56;
                    case 3: return 35;
                    case 4: return 20;
                    case 5: return 13;
                    default: throw new Exception();
                }

            }
            else
            {
                switch (key.finger)
                {
                    case 1: return 612;
                    case 2: return 668;
                    case 3: return 689;
                    case 4: return 704;
                    case 5: return 712;
                    default: throw new Exception();
                }
            }
        }

        int getY(Key key)
        {
            if (key.hand == Key.Hand.Left)
            {
                switch (key.finger)
                {
                    case 1: return 85;
                    case 2: return 40;
                    case 3: return 41;
                    case 4: return 60;
                    case 5: return 92;
                    default: throw new Exception();
                }

            }
            else
            {
                switch (key.finger)
                {
                    case 1: return 85;
                    case 2: return 40;
                    case 3: return 42;
                    case 4: return 60;
                    case 5: return 91;
                    default: throw new Exception();
                }
            }
        }


    }
}
