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
        public Finger finger {get; set; }

        public Key(Finger finger)
        {
            InitializeComponent();

            this.Enabled = false;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.finger = finger;
        }

    }
}
