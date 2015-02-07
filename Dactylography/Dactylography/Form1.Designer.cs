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
            this.keyboard1 = new Dactylography.Keyboard();
            this.text1 = new Dactylography.Text();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            // keyboard1
            // 
            this.keyboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyboard1.BackgroundImage")));
            this.keyboard1.fingerKey = null;
            this.keyboard1.Location = new System.Drawing.Point(0, 28);
            this.keyboard1.Name = "keyboard1";
            this.keyboard1.Size = new System.Drawing.Size(733, 154);
            this.keyboard1.TabIndex = 0;
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
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyboard keyboard1;
        private System.Windows.Forms.Label label1;
        private Text text1;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}

