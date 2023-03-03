using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красивыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСайзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size = new System.Windows.Forms.ToolStripComboBox();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найстройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьТемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаОСебеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.сменитьКодировкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крутаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.найстройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(763, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.создатьНовыйДокументToolStripMenuItem,
            this.выходToolStripMenuItem1,
            this.печатьToolStripMenuItem,
            this.FuckToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(481, 40);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.OpenFile);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(481, 40);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(481, 40);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // создатьНовыйДокументToolStripMenuItem
            // 
            this.создатьНовыйДокументToolStripMenuItem.Name = "создатьНовыйДокументToolStripMenuItem";
            this.создатьНовыйДокументToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьНовыйДокументToolStripMenuItem.Size = new System.Drawing.Size(481, 40);
            this.создатьНовыйДокументToolStripMenuItem.Text = "Создать новый документ";
            this.создатьНовыйДокументToolStripMenuItem.Click += new System.EventHandler(this.CreateNewDocument);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(481, 40);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.Exit);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(481, 40);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.Print);
            // 
            // FuckToolStripMenuItem
            // 
            this.FuckToolStripMenuItem.Name = "FuckToolStripMenuItem";
            this.FuckToolStripMenuItem.Size = new System.Drawing.Size(481, 40);
            this.FuckToolStripMenuItem.Text = "F**k";
            this.FuckToolStripMenuItem.Click += new System.EventHandler(this.Fuck);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьToolStripMenuItem,
            this.изменитьЦветToolStripMenuItem,
            this.изменитьСайзToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // выделитьToolStripMenuItem
            // 
            this.выделитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жирнымToolStripMenuItem,
            this.курсивомToolStripMenuItem});
            this.выделитьToolStripMenuItem.Name = "выделитьToolStripMenuItem";
            this.выделитьToolStripMenuItem.Size = new System.Drawing.Size(386, 40);
            this.выделитьToolStripMenuItem.Text = "Выделить";
            // 
            // жирнымToolStripMenuItem
            // 
            this.жирнымToolStripMenuItem.Name = "жирнымToolStripMenuItem";
            this.жирнымToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.жирнымToolStripMenuItem.Text = "Жирным";
            this.жирнымToolStripMenuItem.Click += new System.EventHandler(this.BoldClick);
            // 
            // курсивомToolStripMenuItem
            // 
            this.курсивомToolStripMenuItem.Name = "курсивомToolStripMenuItem";
            this.курсивомToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.курсивомToolStripMenuItem.Text = "Курсивом";
            this.курсивомToolStripMenuItem.Click += new System.EventHandler(this.ItalicClick);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.красивыйToolStripMenuItem,
            this.белыйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.серыйToolStripMenuItem});
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(386, 40);
            this.изменитьЦветToolStripMenuItem.Text = "Изменить цвет";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.ToRed);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.ToBlue);
            // 
            // красивыйToolStripMenuItem
            // 
            this.красивыйToolStripMenuItem.Name = "красивыйToolStripMenuItem";
            this.красивыйToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.красивыйToolStripMenuItem.Text = "Красивый";
            this.красивыйToolStripMenuItem.Click += new System.EventHandler(this.ToBlack);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.белыйToolStripMenuItem.Text = "Белый";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.ToWhite);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.ToGreen);
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(227, 40);
            this.серыйToolStripMenuItem.Text = "Серый";
            this.серыйToolStripMenuItem.Click += new System.EventHandler(this.ToGray);
            // 
            // изменитьСайзToolStripMenuItem
            // 
            this.изменитьСайзToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size});
            this.изменитьСайзToolStripMenuItem.Name = "изменитьСайзToolStripMenuItem";
            this.изменитьСайзToolStripMenuItem.Size = new System.Drawing.Size(386, 40);
            this.изменитьСайзToolStripMenuItem.Text = "Изменить сайз";
            // 
            // Size
            // 
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(175, 33);
            this.Size.Text = "Напиши в меня";
            this.Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Size_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(386, 40);
            this.изменитьToolStripMenuItem.Text = "Изменить ПОЛНОСТЬЮ";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ShriftChange);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyClick);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.CutClick);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(331, 40);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.PasteClick);
            // 
            // найстройкиToolStripMenuItem
            // 
            this.найстройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьТемуToolStripMenuItem,
            this.сменитьКодировкуToolStripMenuItem});
            this.найстройкиToolStripMenuItem.Name = "найстройкиToolStripMenuItem";
            this.найстройкиToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.найстройкиToolStripMenuItem.Text = "Найстройки";
            // 
            // сменитьТемуToolStripMenuItem
            // 
            this.сменитьТемуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тёмнаяToolStripMenuItem,
            this.светлаяToolStripMenuItem});
            this.сменитьТемуToolStripMenuItem.Name = "сменитьТемуToolStripMenuItem";
            this.сменитьТемуToolStripMenuItem.Size = new System.Drawing.Size(340, 40);
            this.сменитьТемуToolStripMenuItem.Text = "Сменить тему";
            // 
            // тёмнаяToolStripMenuItem
            // 
            this.тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            this.тёмнаяToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.тёмнаяToolStripMenuItem.Text = "Тёмная";
            this.тёмнаяToolStripMenuItem.Click += new System.EventHandler(this.ChangeToDark);
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.ChangeToWhite);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаОСебеToolStripMenuItem,
            this.справкаОПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // справкаОСебеToolStripMenuItem
            // 
            this.справкаОСебеToolStripMenuItem.Name = "справкаОСебеToolStripMenuItem";
            this.справкаОСебеToolStripMenuItem.Size = new System.Drawing.Size(362, 40);
            this.справкаОСебеToolStripMenuItem.Text = "Справка о себе";
            this.справкаОСебеToolStripMenuItem.Click += new System.EventHandler(this.OnCrazy);
            // 
            // справкаОПрограммеToolStripMenuItem
            // 
            this.справкаОПрограммеToolStripMenuItem.Name = "справкаОПрограммеToolStripMenuItem";
            this.справкаОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(362, 40);
            this.справкаОПрограммеToolStripMenuItem.Text = "Справка о программе";
            this.справкаОПрограммеToolStripMenuItem.Click += new System.EventHandler(this.GetHelp);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 40);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(763, 420);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Напиши в меня!";
            this.richTextBox1.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // сменитьКодировкуToolStripMenuItem
            // 
            this.сменитьКодировкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8ToolStripMenuItem,
            this.uTF16ToolStripMenuItem,
            this.uTF32ToolStripMenuItem,
            this.крутаяToolStripMenuItem});
            this.сменитьКодировкуToolStripMenuItem.Name = "сменитьКодировкуToolStripMenuItem";
            this.сменитьКодировкуToolStripMenuItem.Size = new System.Drawing.Size(340, 40);
            this.сменитьКодировкуToolStripMenuItem.Text = "Сменить Кодировку";
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            // 
            // uTF16ToolStripMenuItem
            // 
            this.uTF16ToolStripMenuItem.Name = "uTF16ToolStripMenuItem";
            this.uTF16ToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.uTF16ToolStripMenuItem.Text = "UTF-16";
            // 
            // uTF32ToolStripMenuItem
            // 
            this.uTF32ToolStripMenuItem.Name = "uTF32ToolStripMenuItem";
            this.uTF32ToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.uTF32ToolStripMenuItem.Text = "UTF-32";
            // 
            // крутаяToolStripMenuItem
            // 
            this.крутаяToolStripMenuItem.Name = "крутаяToolStripMenuItem";
            this.крутаяToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.крутаяToolStripMenuItem.Text = "Крутая";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 460);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(255, 200);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проектик :)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.NeedSave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem FuckToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem создатьНовыйДокументToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem найстройкиToolStripMenuItem;
        private ToolStripMenuItem сменитьТемуToolStripMenuItem;
        private ToolStripMenuItem тёмнаяToolStripMenuItem;
        private ToolStripMenuItem светлаяToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem выделитьToolStripMenuItem;
        private ToolStripMenuItem жирнымToolStripMenuItem;
        private ToolStripMenuItem курсивомToolStripMenuItem;
        private ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem красивыйToolStripMenuItem;
        private ToolStripMenuItem белыйToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem серыйToolStripMenuItem;
        private ToolStripMenuItem изменитьСайзToolStripMenuItem;
        private ToolStripComboBox Size;
        private ToolStripMenuItem справкаОСебеToolStripMenuItem;
        private ToolStripMenuItem справкаОПрограммеToolStripMenuItem;
        private ToolStripMenuItem сменитьКодировкуToolStripMenuItem;
        private ToolStripMenuItem uTF8ToolStripMenuItem;
        private ToolStripMenuItem uTF16ToolStripMenuItem;
        private ToolStripMenuItem uTF32ToolStripMenuItem;
        private ToolStripMenuItem крутаяToolStripMenuItem;
    }
}