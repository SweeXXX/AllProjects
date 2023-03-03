namespace Host
{
    partial class AddGuest
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbTName = new System.Windows.Forms.TextBox();
            this.tbDateIN = new System.Windows.Forms.TextBox();
            this.tbDateOUT = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblOUT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 26);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Иван";
            this.tbName.TextChanged += new System.EventHandler(this.AddClick);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(12, 64);
            this.tbSName.Multiline = true;
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(193, 26);
            this.tbSName.TabIndex = 5;
            this.tbSName.Text = "Иванов";
            // 
            // tbTName
            // 
            this.tbTName.Location = new System.Drawing.Point(12, 123);
            this.tbTName.Multiline = true;
            this.tbTName.Name = "tbTName";
            this.tbTName.Size = new System.Drawing.Size(193, 26);
            this.tbTName.TabIndex = 7;
            this.tbTName.Text = "Иванович";
            // 
            // tbDateIN
            // 
            this.tbDateIN.Location = new System.Drawing.Point(12, 173);
            this.tbDateIN.Multiline = true;
            this.tbDateIN.Name = "tbDateIN";
            this.tbDateIN.Size = new System.Drawing.Size(193, 26);
            this.tbDateIN.TabIndex = 9;
            this.tbDateIN.Text = "дд.мм.гг";
            // 
            // tbDateOUT
            // 
            this.tbDateOUT.Location = new System.Drawing.Point(12, 226);
            this.tbDateOUT.Multiline = true;
            this.tbDateOUT.Name = "tbDateOUT";
            this.tbDateOUT.Size = new System.Drawing.Size(193, 26);
            this.tbDateOUT.TabIndex = 11;
            this.tbDateOUT.Text = "дд.мм.гг";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(28, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 52);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Сохранить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddClick);
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIN.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIN.Location = new System.Drawing.Point(34, 327);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(134, 25);
            this.lblIN.TabIndex = 13;
            this.lblIN.Text = "Дата Въезда";
            // 
            // lblOUT
            // 
            this.lblOUT.AutoSize = true;
            this.lblOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOUT.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOUT.Location = new System.Drawing.Point(198, 327);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(136, 25);
            this.lblOUT.TabIndex = 14;
            this.lblOUT.Text = "Дата Выезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(211, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(211, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(211, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(211, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(211, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(370, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOUT);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDateOUT);
            this.Controls.Add(this.tbDateIN);
            this.Controls.Add(this.tbTName);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.tbName);
            this.Name = "AddGuest";
            this.Text = "AddGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.TextBox tbSName;
        internal System.Windows.Forms.TextBox tbTName;
        internal System.Windows.Forms.TextBox tbDateIN;
        internal System.Windows.Forms.TextBox tbDateOUT;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label lblIN;
        internal System.Windows.Forms.Label lblOUT;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
    }
}