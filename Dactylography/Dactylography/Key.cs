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
    public partial class Key : Button
    {
        public enum Hand { Left, Right };

        internal Hand hand { get; set; }

        internal int finger { get; set; }


        public Key(Hand hand, int finger)
        {
            InitializeComponent();

            this.Enabled = false;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           // this.ForeColor = Color.Black;

            this.hand = hand;
            this.finger = finger;
        }

        


    }
}
