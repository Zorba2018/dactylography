namespace Dactylography
{
    partial class FormSettings
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
            this.cbPreviewKey = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSkip = new System.Windows.Forms.RadioButton();
            this.rbWait = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPreviewFinger = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPreviewKey
            // 
            this.cbPreviewKey.AutoSize = true;
            this.cbPreviewKey.Location = new System.Drawing.Point(12, 12);
            this.cbPreviewKey.Name = "cbPreviewKey";
            this.cbPreviewKey.Size = new System.Drawing.Size(146, 17);
            this.cbPreviewKey.TabIndex = 0;
            this.cbPreviewKey.Text = "Prikaz slova na tipkovnici";
            this.cbPreviewKey.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWait);
            this.groupBox1.Controls.Add(this.rbSkip);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Krivo unesena slova";
            // 
            // rbSkip
            // 
            this.rbSkip.AutoSize = true;
            this.rbSkip.Location = new System.Drawing.Point(17, 42);
            this.rbSkip.Name = "rbSkip";
            this.rbSkip.Size = new System.Drawing.Size(66, 17);
            this.rbSkip.TabIndex = 0;
            this.rbSkip.TabStop = true;
            this.rbSkip.Text = "Preskoči";
            this.rbSkip.UseVisualStyleBackColor = true;
            // 
            // rbWait
            // 
            this.rbWait.AutoSize = true;
            this.rbWait.Location = new System.Drawing.Point(17, 19);
            this.rbWait.Name = "rbWait";
            this.rbWait.Size = new System.Drawing.Size(64, 17);
            this.rbWait.TabIndex = 1;
            this.rbWait.TabStop = true;
            this.rbWait.Text = "Sačekaj";
            this.rbWait.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbPreviewFinger
            // 
            this.cbPreviewFinger.AutoSize = true;
            this.cbPreviewFinger.Location = new System.Drawing.Point(12, 36);
            this.cbPreviewFinger.Name = "cbPreviewFinger";
            this.cbPreviewFinger.Size = new System.Drawing.Size(81, 17);
            this.cbPreviewFinger.TabIndex = 4;
            this.cbPreviewFinger.Text = "Prikaz prsta";
            this.cbPreviewFinger.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 170);
            this.Controls.Add(this.cbPreviewFinger);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbPreviewKey);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPreviewKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWait;
        private System.Windows.Forms.RadioButton rbSkip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbPreviewFinger;
    }
}