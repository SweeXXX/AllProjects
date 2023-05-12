namespace WindowsFormsApp6
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выиртуальнаяБиблиотекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.избранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 664);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 644);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКнигиToolStripMenuItem,
            this.открытьКнигиToolStripMenuItem,
            this.выиртуальнаяБиблиотекаToolStripMenuItem,
            this.избранноеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьКнигиToolStripMenuItem
            // 
            this.добавитьКнигиToolStripMenuItem.Name = "добавитьКнигиToolStripMenuItem";
            this.добавитьКнигиToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.добавитьКнигиToolStripMenuItem.Text = "Добавить книги";
            // 
            // открытьКнигиToolStripMenuItem
            // 
            this.открытьКнигиToolStripMenuItem.Name = "открытьКнигиToolStripMenuItem";
            this.открытьКнигиToolStripMenuItem.Size = new System.Drawing.Size(200, 29);
            this.открытьКнигиToolStripMenuItem.Text = "Открыть список книг";
            // 
            // выиртуальнаяБиблиотекаToolStripMenuItem
            // 
            this.выиртуальнаяБиблиотекаToolStripMenuItem.Name = "выиртуальнаяБиблиотекаToolStripMenuItem";
            this.выиртуальнаяБиблиотекаToolStripMenuItem.Size = new System.Drawing.Size(229, 89);
            this.выиртуальнаяБиблиотекаToolStripMenuItem.Text = "Виртуальная библиотека";
            // 
            // избранноеToolStripMenuItem
            // 
            this.избранноеToolStripMenuItem.Name = "избранноеToolStripMenuItem";
            this.избранноеToolStripMenuItem.Size = new System.Drawing.Size(119, 89);
            this.избранноеToolStripMenuItem.Text = "Избранное";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выиртуальнаяБиблиотекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem избранноеToolStripMenuItem;
    }
}