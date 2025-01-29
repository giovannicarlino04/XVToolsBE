namespace CMSTool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfo4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfo5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInfo6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfo7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChar = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character";
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(156, 100);
            this.txtInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(193, 22);
            this.txtInfo1.TabIndex = 2;
            this.txtInfo1.TextChanged += new System.EventHandler(this.txtInfo1_TextChanged);
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(156, 132);
            this.txtInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(193, 22);
            this.txtInfo2.TabIndex = 4;
            this.txtInfo2.TextChanged += new System.EventHandler(this.txtInfo2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "EAN";
            // 
            // txtInfo3
            // 
            this.txtInfo3.Location = new System.Drawing.Point(156, 164);
            this.txtInfo3.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(193, 22);
            this.txtInfo3.TabIndex = 6;
            this.txtInfo3.TextChanged += new System.EventHandler(this.txtInfo3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "3?";
            // 
            // txtInfo4
            // 
            this.txtInfo4.Location = new System.Drawing.Point(156, 193);
            this.txtInfo4.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo4.Name = "txtInfo4";
            this.txtInfo4.Size = new System.Drawing.Size(193, 22);
            this.txtInfo4.TabIndex = 8;
            this.txtInfo4.TextChanged += new System.EventHandler(this.txtInfo4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skills Animations";
            // 
            // txtInfo5
            // 
            this.txtInfo5.Location = new System.Drawing.Point(156, 225);
            this.txtInfo5.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo5.Name = "txtInfo5";
            this.txtInfo5.Size = new System.Drawing.Size(193, 22);
            this.txtInfo5.TabIndex = 10;
            this.txtInfo5.TextChanged += new System.EventHandler(this.txtInfo5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "BCM";
            // 
            // txtInfo6
            // 
            this.txtInfo6.Location = new System.Drawing.Point(156, 257);
            this.txtInfo6.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo6.Name = "txtInfo6";
            this.txtInfo6.Size = new System.Drawing.Size(193, 22);
            this.txtInfo6.TabIndex = 12;
            this.txtInfo6.TextChanged += new System.EventHandler(this.txtInfo6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "BAC";
            // 
            // txtInfo7
            // 
            this.txtInfo7.Location = new System.Drawing.Point(156, 289);
            this.txtInfo7.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo7.Name = "txtInfo7";
            this.txtInfo7.Size = new System.Drawing.Size(193, 22);
            this.txtInfo7.TabIndex = 14;
            this.txtInfo7.TextChanged += new System.EventHandler(this.txtInfo7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "7?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Character";
            // 
            // cbChar
            // 
            this.cbChar.FormattingEnabled = true;
            this.cbChar.Location = new System.Drawing.Point(27, 63);
            this.cbChar.Margin = new System.Windows.Forms.Padding(4);
            this.cbChar.Name = "cbChar";
            this.cbChar.Size = new System.Drawing.Size(160, 24);
            this.cbChar.TabIndex = 16;
            this.cbChar.SelectedIndexChanged += new System.EventHandler(this.cbChar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.cbChar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInfo7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInfo6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInfo5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInfo4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInfo3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CMSTool (PS3 & Xbox 360)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfo3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfo4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInfo5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInfo6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfo7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbChar;
    }
}

