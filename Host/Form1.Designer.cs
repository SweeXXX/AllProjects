using System.Drawing;

namespace Host
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.tlpAddDeleteCancel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddGuestTLP = new System.Windows.Forms.Button();
            this.btnCancelTLP = new System.Windows.Forms.Button();
            this.btnDeleteGuestTLP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SNameGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOUT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFIO = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDateExit = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDateEnter = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ShowGuest = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNumberID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblGuestsList = new System.Windows.Forms.Label();
            this.dataGridViewSort = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpAddDeleteCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.btnClock);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 35);
            this.panel4.TabIndex = 6;
            // 
            // btnClock
            // 
            this.btnClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClock.BackgroundImage")));
            this.btnClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClock.Location = new System.Drawing.Point(202, 4);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(40, 32);
            this.btnClock.TabIndex = 7;
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.UpdateClock);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ShowAddForm);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1478, 35);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtbSearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(848, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 35);
            this.panel5.TabIndex = 7;
            // 
            // rtbSearch
            // 
            this.rtbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbSearch.Location = new System.Drawing.Point(0, 0);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(589, 35);
            this.rtbSearch.TabIndex = 6;
            this.rtbSearch.Text = "Поиск...";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1440, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 687);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LeftPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(1478, 687);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LeftPanel.Controls.Add(this.tableLayoutPanel1);
            this.LeftPanel.Controls.Add(this.tlpAddDeleteCancel);
            this.LeftPanel.Controls.Add(this.checkedListBox1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(110, 665);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(222, 685);
            this.LeftPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Save, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 209);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 476);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 171);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 26);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "дд.мм.гг - Дата рождения";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 28);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Иванов";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 103);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 26);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "дд.мм.гг - Дата заезда";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 135);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 29);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "дд.мм.гг - Дата выезда";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Иван";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 27);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Иванович";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 203);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(191, 93);
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tlpAddDeleteCancel
            // 
            this.tlpAddDeleteCancel.ColumnCount = 1;
            this.tlpAddDeleteCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddDeleteCancel.Controls.Add(this.btnAddGuestTLP, 0, 0);
            this.tlpAddDeleteCancel.Controls.Add(this.btnCancelTLP, 0, 2);
            this.tlpAddDeleteCancel.Controls.Add(this.btnDeleteGuestTLP, 0, 1);
            this.tlpAddDeleteCancel.Controls.Add(this.button1, 0, 3);
            this.tlpAddDeleteCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAddDeleteCancel.Location = new System.Drawing.Point(0, 0);
            this.tlpAddDeleteCancel.Name = "tlpAddDeleteCancel";
            this.tlpAddDeleteCancel.RowCount = 4;
            this.tlpAddDeleteCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddDeleteCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddDeleteCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpAddDeleteCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpAddDeleteCancel.Size = new System.Drawing.Size(222, 273);
            this.tlpAddDeleteCancel.TabIndex = 4;
            this.tlpAddDeleteCancel.Visible = false;
            // 
            // btnAddGuestTLP
            // 
            this.btnAddGuestTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddGuestTLP.Location = new System.Drawing.Point(3, 3);
            this.btnAddGuestTLP.Name = "btnAddGuestTLP";
            this.btnAddGuestTLP.Size = new System.Drawing.Size(216, 64);
            this.btnAddGuestTLP.TabIndex = 0;
            this.btnAddGuestTLP.Text = "Параметры Гостя";
            this.btnAddGuestTLP.UseVisualStyleBackColor = true;
            this.btnAddGuestTLP.Click += new System.EventHandler(this.AddGuest);
            // 
            // btnCancelTLP
            // 
            this.btnCancelTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelTLP.Location = new System.Drawing.Point(3, 143);
            this.btnCancelTLP.Name = "btnCancelTLP";
            this.btnCancelTLP.Size = new System.Drawing.Size(216, 64);
            this.btnCancelTLP.TabIndex = 2;
            this.btnCancelTLP.Text = "Закрыть";
            this.btnCancelTLP.UseVisualStyleBackColor = true;
            this.btnCancelTLP.Click += new System.EventHandler(this.btnCancelTLP_Click);
            // 
            // btnDeleteGuestTLP
            // 
            this.btnDeleteGuestTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteGuestTLP.Location = new System.Drawing.Point(3, 73);
            this.btnDeleteGuestTLP.Name = "btnDeleteGuestTLP";
            this.btnDeleteGuestTLP.Size = new System.Drawing.Size(216, 64);
            this.btnDeleteGuestTLP.TabIndex = 1;
            this.btnDeleteGuestTLP.Text = "Удалить Гостя";
            this.btnDeleteGuestTLP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NAdd);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Зарезервировано ",
            "Свободно",
            "Заняты",
            "Выписываются"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 92);
            this.checkedListBox1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 38);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1.DoubleClick += new System.EventHandler(this.ShowGuest_DClick);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.splitContainer2.Panel2.Controls.Add(this.lblFIO);
            this.splitContainer2.Panel2.Controls.Add(this.panel8);
            this.splitContainer2.Panel2.Controls.Add(this.panel7);
            this.splitContainer2.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer2.Panel2.Controls.Add(this.ShowGuest);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Controls.Add(this.lblNumberID);
            this.splitContainer2.Size = new System.Drawing.Size(1248, 647);
            this.splitContainer2.SplitterDistance = 626;
            this.splitContainer2.TabIndex = 6;
            this.splitContainer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameGuest,
            this.SNameGuest,
            this.TName,
            this.DateIN,
            this.DateOUT});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(626, 647);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // NameGuest
            // 
            this.NameGuest.Text = "Имя";
            this.NameGuest.Width = 63;
            // 
            // SNameGuest
            // 
            this.SNameGuest.Text = "Фамилия";
            this.SNameGuest.Width = 103;
            // 
            // TName
            // 
            this.TName.Text = "Отчество";
            this.TName.Width = 119;
            // 
            // DateIN
            // 
            this.DateIN.Text = "Дата заезда";
            this.DateIN.Width = 115;
            // 
            // DateOUT
            // 
            this.DateOUT.Text = "Дата выезда";
            this.DateOUT.Width = 128;
            // 
            // lblFIO
            // 
            this.lblFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(94)))), ((int)(((byte)(150)))));
            this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.ForeColor = System.Drawing.Color.White;
            this.lblFIO.Location = new System.Drawing.Point(10, 191);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(382, 44);
            this.lblFIO.TabIndex = 21;
            this.lblFIO.Text = "ФИО";
            this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.lblDateExit);
            this.panel8.Controls.Add(this.lblDate2);
            this.panel8.Location = new System.Drawing.Point(11, 366);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 80);
            this.panel8.TabIndex = 20;
            // 
            // lblDateExit
            // 
            this.lblDateExit.Location = new System.Drawing.Point(0, 29);
            this.lblDateExit.Name = "lblDateExit";
            this.lblDateExit.Size = new System.Drawing.Size(271, 51);
            this.lblDateExit.TabIndex = 2;
            this.lblDateExit.Text = "asdfasd";
            this.lblDateExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate2.Location = new System.Drawing.Point(-4, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(109, 20);
            this.lblDate2.TabIndex = 1;
            this.lblDate2.Text = "Дата выезда";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.lblDateEnter);
            this.panel7.Controls.Add(this.lblDate1);
            this.panel7.Location = new System.Drawing.Point(11, 250);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 80);
            this.panel7.TabIndex = 19;
            // 
            // lblDateEnter
            // 
            this.lblDateEnter.Location = new System.Drawing.Point(0, 29);
            this.lblDateEnter.Name = "lblDateEnter";
            this.lblDateEnter.Size = new System.Drawing.Size(271, 51);
            this.lblDateEnter.TabIndex = 3;
            this.lblDateEnter.Text = "asdfasd";
            this.lblDateEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate1.Location = new System.Drawing.Point(-1, 0);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(106, 20);
            this.lblDate1.TabIndex = 0;
            this.lblDate1.Text = "Дата заезда";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatus.Location = new System.Drawing.Point(5, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 32);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Статус";
            // 
            // ShowGuest
            // 
            this.ShowGuest.Location = new System.Drawing.Point(126, 487);
            this.ShowGuest.Name = "ShowGuest";
            this.ShowGuest.Size = new System.Drawing.Size(169, 35);
            this.ShowGuest.TabIndex = 17;
            this.ShowGuest.Text = "Просмотр карточки";
            this.ShowGuest.UseVisualStyleBackColor = true;
            this.ShowGuest.Click += new System.EventHandler(this.ShowInfoForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblNumberID
            // 
            this.lblNumberID.AutoSize = true;
            this.lblNumberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberID.Location = new System.Drawing.Point(8, 12);
            this.lblNumberID.Name = "lblNumberID";
            this.lblNumberID.Size = new System.Drawing.Size(137, 32);
            this.lblNumberID.TabIndex = 15;
            this.lblNumberID.Text = "Номер №";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblGuestsList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1248, 38);
            this.panel6.TabIndex = 5;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseGuestPanel);
            // 
            // lblGuestsList
            // 
            this.lblGuestsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGuestsList.ForeColor = System.Drawing.SystemColors.Window;
            this.lblGuestsList.Location = new System.Drawing.Point(279, 3);
            this.lblGuestsList.Name = "lblGuestsList";
            this.lblGuestsList.Size = new System.Drawing.Size(160, 32);
            this.lblGuestsList.TabIndex = 2;
            this.lblGuestsList.Text = "Список Гостей\r\n\r\n";
            // 
            // dataGridViewSort
            // 
            this.dataGridViewSort.AllowUserToOrderColumns = true;
            this.dataGridViewSort.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSort.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSort.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSort.Name = "dataGridViewSort";
            this.dataGridViewSort.RowHeadersWidth = 51;
            this.dataGridViewSort.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewSort.Size = new System.Drawing.Size(500, 567);
            this.dataGridViewSort.TabIndex = 4;
            this.dataGridViewSort.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSort_CellMouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 95);
            this.button2.TabIndex = 15;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(897, 660);
            this.Name = "MainForm";
            this.Text = "Hostel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpAddDeleteCancel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.RichTextBox rtbSearch;
        internal System.Windows.Forms.Button btnClock;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView dataGridViewSort;
        internal System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Panel LeftPanel;
        internal System.Windows.Forms.CheckedListBox checkedListBox1;
        internal System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Label lblGuestsList;
        internal System.Windows.Forms.SplitContainer splitContainer2;
        internal System.Windows.Forms.Label lblFIO;
        internal System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.Label lblDateExit;
        internal System.Windows.Forms.Label lblDate2;
        internal System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Label lblDateEnter;
        internal System.Windows.Forms.Label lblDate1;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Button ShowGuest;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label lblNumberID;
        internal System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ColumnHeader NameGuest;
        internal System.Windows.Forms.ColumnHeader SNameGuest;
        internal System.Windows.Forms.ColumnHeader TName;
        internal System.Windows.Forms.ColumnHeader DateIN;
        internal System.Windows.Forms.ColumnHeader DateOUT;
        internal System.Windows.Forms.TableLayoutPanel tlpAddDeleteCancel;
        internal System.Windows.Forms.Button btnAddGuestTLP;
        internal System.Windows.Forms.Button btnCancelTLP;
        internal System.Windows.Forms.Button btnDeleteGuestTLP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.TextBox textBox6;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
    }
}

