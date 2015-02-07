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
    public partial class FormSettings : Form
    {
        private Form1 f;
        public FormSettings(Form1 f)
        {
            InitializeComponent();
            this.f = f;

            this.CancelButton = button2;

            this.cbPreviewKey.Checked = f.PreviewKey;
            this.cbPreviewFinger.Checked = f.PreviewFinger;

            if (f.Wait)
            {
                rbWait.Checked = true;
            }
            else
            {
                rbSkip.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.PreviewKey = cbPreviewKey.Checked;
            f.PreviewFinger = cbPreviewFinger.Checked;
            f.Wait = rbWait.Checked;
            f.RefreshForm();

            this.Dispose();
        }



    }
}
