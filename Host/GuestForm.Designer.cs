namespace Host
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.lblCardGuest = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblNN = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblCountOfDay = new System.Windows.Forms.Label();
            this.cbTravelAnimal = new System.Windows.Forms.CheckBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCardGuest
            // 
            this.lblCardGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.lblCardGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardGuest.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCardGuest.Location = new System.Drawing.Point(137, 9);
            this.lblCardGuest.Name = "lblCardGuest";
            this.lblCardGuest.Size = new System.Drawing.Size(164, 31);
            this.lblCardGuest.TabIndex = 0;
            this.lblCardGuest.Text = "Карточка Гостя";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBirthDate.Location = new System.Drawing.Point(32, 153);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(414, 37);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "Дата Рождения";
            // 
            // lblFIO
            // 
            this.lblFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFIO.Location = new System.Drawing.Point(32, 71);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(414, 32);
            this.lblFIO.TabIndex = 2;
            this.lblFIO.Text = "ФИО";
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPayment.Location = new System.Drawing.Point(29, 228);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(414, 32);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Оплата";
            // 
            // lblNN
            // 
            this.lblNN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNN.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNN.Location = new System.Drawing.Point(70, 294);
            this.lblNN.Name = "lblNN";
            this.lblNN.Size = new System.Drawing.Size(57, 40);
            this.lblNN.TabIndex = 5;
            this.lblNN.Text = "00";
            this.lblNN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(124, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtract.Image")));
            this.btnSubtract.Location = new System.Drawing.Point(34, 294);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(39, 40);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // lblCountOfDay
            // 
            this.lblCountOfDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblCountOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountOfDay.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCountOfDay.Location = new System.Drawing.Point(169, 294);
            this.lblCountOfDay.Name = "lblCountOfDay";
            this.lblCountOfDay.Size = new System.Drawing.Size(245, 40);
            this.lblCountOfDay.TabIndex = 9;
            this.lblCountOfDay.Text = "Количество дней";
            this.lblCountOfDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTravelAnimal
            // 
            this.cbTravelAnimal.AutoSize = true;
            this.cbTravelAnimal.BackColor = System.Drawing.Color.Magenta;
            this.cbTravelAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTravelAnimal.ForeColor = System.Drawing.SystemColors.Window;
            this.cbTravelAnimal.Location = new System.Drawing.Point(34, 352);
            this.cbTravelAnimal.Name = "cbTravelAnimal";
            this.cbTravelAnimal.Size = new System.Drawing.Size(301, 29);
            this.cbTravelAnimal.TabIndex = 10;
            this.cbTravelAnimal.Text = "Путешествую с животными";
            this.cbTravelAnimal.UseVisualStyleBackColor = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(441, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(467, 414);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.cbTravelAnimal);
            this.Controls.Add(this.lblCountOfDay);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNN);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblCardGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCardGuest;
        internal System.Windows.Forms.Label lblBirthDate;
        internal System.Windows.Forms.Label lblFIO;
        internal System.Windows.Forms.Label lblPayment;
        internal System.Windows.Forms.Label lblNN;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnSubtract;
        internal System.Windows.Forms.Label lblCountOfDay;
        internal System.Windows.Forms.CheckBox cbTravelAnimal;
        internal System.Windows.Forms.Label lblClose;
        
    }
}