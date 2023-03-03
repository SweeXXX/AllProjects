namespace WindowsFormsApp1
{
    partial class Form2
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
            this.privetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petuhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privetToolStripMenuItem,
            this.pokaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // privetToolStripMenuItem
            // 
            this.privetToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.privetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petuhToolStripMenuItem});
            this.privetToolStripMenuItem.Name = "privetToolStripMenuItem";
            this.privetToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.privetToolStripMenuItem.Text = "Privet";
            this.privetToolStripMenuItem.DoubleClick += new System.EventHandler(this.privetToolStripMenuItem_DoubleClick);
            // 
            // pokaToolStripMenuItem
            // 
            this.pokaToolStripMenuItem.Name = "pokaToolStripMenuItem";
            this.pokaToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.pokaToolStripMenuItem.Text = "Poka";
            // 
            // petuhToolStripMenuItem
            // 
            this.petuhToolStripMenuItem.Name = "petuhToolStripMenuItem";
            this.petuhToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.petuhToolStripMenuItem.Text = "petuh";
            this.petuhToolStripMenuItem.Click += new System.EventHandler(this.petuhToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem privetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petuhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokaToolStripMenuItem;
    }
}