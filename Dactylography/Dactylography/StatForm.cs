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
    public partial class StatForm : Form
    {
        Form1 f;
        public StatForm(Form1 a)
        {
            f = a;
            InitializeComponent();
        }
    }
}
