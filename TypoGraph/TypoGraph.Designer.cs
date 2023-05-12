namespace TypoGraph
{
    partial class TypoGraph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypoGraph));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTypoGraphStart = new System.Windows.Forms.Button();
            this.rtbEnter = new System.Windows.Forms.RichTextBox();
            this.lblClearRtb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(361, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "-Это \"Типограф\"?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(361, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "-Нет, это Тупо(й)Граф";
            // 
            // btnTypoGraphStart
            // 
            this.btnTypoGraphStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTypoGraphStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTypoGraphStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTypoGraphStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTypoGraphStart.Location = new System.Drawing.Point(367, 400);
            this.btnTypoGraphStart.Name = "btnTypoGraphStart";
            this.btnTypoGraphStart.Size = new System.Drawing.Size(250, 83);
            this.btnTypoGraphStart.TabIndex = 4;
            this.btnTypoGraphStart.Text = "Отграфить";
            this.btnTypoGraphStart.UseVisualStyleBackColor = false;
            this.btnTypoGraphStart.Click += new System.EventHandler(this.TypoGraph_Click);
            // 
            // rtbEnter
            // 
            this.rtbEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEnter.BackColor = System.Drawing.Color.White;
            this.rtbEnter.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEnter.ForeColor = System.Drawing.Color.Black;
            this.rtbEnter.Location = new System.Drawing.Point(43, 148);
            this.rtbEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbEnter.Name = "rtbEnter";
            this.rtbEnter.Size = new System.Drawing.Size(899, 223);
            this.rtbEnter.TabIndex = 2;
            this.rtbEnter.Text = "";
            // 
            // lblClearRtb
            // 
            this.lblClearRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearRtb.AutoSize = true;
            this.lblClearRtb.BackColor = System.Drawing.Color.Gray;
            this.lblClearRtb.Location = new System.Drawing.Point(913, 148);
            this.lblClearRtb.Name = "lblClearRtb";
            this.lblClearRtb.Size = new System.Drawing.Size(29, 27);
            this.lblClearRtb.TabIndex = 5;
            this.lblClearRtb.Text = "X";
            this.lblClearRtb.Click += new System.EventHandler(this.ClearRtb_Click);
            // 
            // TypoGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lblClearRtb);
            this.Controls.Add(this.btnTypoGraphStart);
            this.Controls.Add(this.rtbEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1000, 570);
            this.Name = "TypoGraph";
            this.Text = "ТупоГраф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTypoGraphStart;
        private System.Windows.Forms.RichTextBox rtbEnter;
        private System.Windows.Forms.Label lblClearRtb;
    }
}

