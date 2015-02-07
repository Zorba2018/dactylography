namespace Dactylography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.učitajVježbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srednjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teškaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vlastitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krairajVježbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text1 = new Dactylography.Text();
            this.keyboard1 = new Dactylography.Keyboard();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.učitajVježbuToolStripMenuItem,
            this.krairajVježbuToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Datoteka";
            // 
            // učitajVježbuToolStripMenuItem
            // 
            this.učitajVježbuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laganaToolStripMenuItem,
            this.srednjaToolStripMenuItem,
            this.teškaToolStripMenuItem,
            this.toolStripSeparator2,
            this.vlastitaToolStripMenuItem});
            this.učitajVježbuToolStripMenuItem.Name = "učitajVježbuToolStripMenuItem";
            this.učitajVježbuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.učitajVježbuToolStripMenuItem.Text = "Učitaj vježbu";
            // 
            // laganaToolStripMenuItem
            // 
            this.laganaToolStripMenuItem.Name = "laganaToolStripMenuItem";
            this.laganaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.laganaToolStripMenuItem.Text = "Lagana";
            // 
            // srednjaToolStripMenuItem
            // 
            this.srednjaToolStripMenuItem.Name = "srednjaToolStripMenuItem";
            this.srednjaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.srednjaToolStripMenuItem.Text = "Srednja";
            // 
            // teškaToolStripMenuItem
            // 
            this.teškaToolStripMenuItem.Name = "teškaToolStripMenuItem";
            this.teškaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.teškaToolStripMenuItem.Text = "Teška";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(110, 6);
            // 
            // vlastitaToolStripMenuItem
            // 
            this.vlastitaToolStripMenuItem.Name = "vlastitaToolStripMenuItem";
            this.vlastitaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.vlastitaToolStripMenuItem.Text = "Vlastita";
            // 
            // krairajVježbuToolStripMenuItem
            // 
            this.krairajVježbuToolStripMenuItem.Name = "krairajVježbuToolStripMenuItem";
            this.krairajVježbuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.krairajVježbuToolStripMenuItem.Text = "Kreiraj vježbu";
            this.krairajVježbuToolStripMenuItem.Click += new System.EventHandler(this.krairajVježbuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem,
            this.toolStripSeparator3,
            this.statistikaToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton2.Text = "Alati";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // text1
            // 
            this.text1.Enabled = false;
            this.text1.Location = new System.Drawing.Point(0, 188);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(733, 148);
            this.text1.TabIndex = 2;
            this.text1.Text = "";
            this.text1.Txt = null;
            // 
            // keyboard1
            // 
            this.keyboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyboard1.BackgroundImage")));
            this.keyboard1.FingerKey = null;
            this.keyboard1.Location = new System.Drawing.Point(0, 28);
            this.keyboard1.Name = "keyboard1";
            this.keyboard1.Size = new System.Drawing.Size(733, 154);
            this.keyboard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 339);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyboard1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyboard keyboard1;
        private System.Windows.Forms.Label label1;
        private Text text1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem učitajVježbuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem srednjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teškaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vlastitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krairajVježbuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}

