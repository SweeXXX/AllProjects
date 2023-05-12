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
using System.Configuration;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;
        public Form1()
        {
            InitializeComponent();




            Init();

        }
        public void Init()
        {
            filename = string.Empty;
            isFileChanged = false;

        }

        #region File 
        public void CreateNewDocument(object sender, EventArgs e) // создает новый документ, вызывая диалоговое окно
        {
            NeedSave(sender, e);
            isFileChanged = false;
            richTextBox1.Text = String.Empty;
            filename = String.Empty;
        }

        private void SaveFile(string _filename)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (_filename == "")
            {
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
                Text = filename;
            }
            catch
            {
                MessageBox.Show("Не удалось!");

            }
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        // сохранить. если у локал. файла уже есть путь,
        // то метод просто пересохраняет файл,
        // иначе надо прописать путь в диалоговом окне
        public void SaveAs(object sender, EventArgs e) // сохранить с указанием пути
        {
            SaveFile("");
        }
        public void OpenFile(object sender, EventArgs e)// открыть локальный текстовый файл
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    Text = filename;
                }
                catch
                {
                    MessageBox.Show("Ошибка! Возможно неверно указан путь файла", "Ошибка!", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void Fuck(object sender, EventArgs e) // по Фану)) 
        {
            var mb = MessageBox.Show("F**k", "F**k", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (mb == DialogResult.OK)
                Application.Exit();
        }
        private void Exit(object sender, EventArgs e)// выход из блокнота
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Print(object sender, EventArgs e) // добавление даты в блокнот
        {
            this.richTextBox1.Text += DateTime.Now;
        }


        #endregion File

        // ^ раздел "Файл"


        #region Settings
        private void ChangeToDark(object sender, EventArgs e)
        {

            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;

        }
        private void ChangeToWhite(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }
        #endregion Settings

        // ^ раздел "Настройки"

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = Text.Replace("*", "");
                isFileChanged = true;
                this.Text = "*" + Text;
            }

        }
        // добавляет "*" в начало имени файла, если файл не сохранен


        private void ShriftChange(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText != null)
                    richTextBox1.Font = fontDialog.Font;
            }
        }

        //^ "глобальное" изменение Шрифта

        private void NeedSave(object sender, EventArgs e)
        {
            if (isFileChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        } //сохранение файла

        #region "Сorrection"
        public void CopyText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }
        public void PasteText()
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + Clipboard.GetText() + richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.TextLength - richTextBox1.SelectionStart);
        }
        private void CopyClick(object sender, EventArgs e)
        {
            try
            {
                CopyText();
            }
            catch { }

        }

        private void CutClick(object sender, EventArgs e)
        {
            try
            {
                CutText();
            }
            catch
            {

            }
        }

        private void PasteClick(object sender, EventArgs e)
        {
            PasteText();
        }
        #endregion "Сorrection"

        /* ^ Правка */


        //private void OnFormClosed(object sender, FormClosedEventArgs e)
        //{
        //    NeedSave(sender, e);
        //}


        #region Fond
        private void BoldClick(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionFont = new Font(Font, FontStyle.Bold);
            }
        }

        private void ItalicClick(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionFont = new Font(Font, FontStyle.Italic);
            }
        }
        private void ToRed(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.Red;
            }
        }
        private void ToBlack(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.Black;
            }
        }
        private void ToBlue(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.Blue;
            }


        }
        private void ToWhite(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.White;
            }
        }
        private void ToGray(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.Gray;
            }
        }
        private void ToGreen(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != String.Empty && richTextBox1.SelectedText != null)
            {
                richTextBox1.SelectionColor = Color.Green;
            }
        }





        #endregion Fond

        // ^ "локальное" изменение Шрифта


        #region Help
        private void GetHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Моя первая рабочая программа на WinForms." +
                "Используется richTextBox.Есть раздел с правкой, который особо не нужен по сути) Если хотите " +
                "включить нормальную тему, то откройте настройки." +
                "Можно менять шрифт целиком или только выделенный. Все шорткаты работают, пользуйтесь ;)\nС окончанием зимы, хз))", "Инструкция", MessageBoxButtons.OK);


        }
        private void OnCrazy(object sender, EventArgs e)
        {
            MessageBox.Show("Я в своем познании настолько преисполнился, " +
                "что я как будто бы уже  сто триллионов миллиардов лет проживаю " +
                "на триллионах и  триллионах таких же планет, как эта Земля, мне " +
                "этот мир абсолютно  понятен, и я здесь ищу только одного - покоя," +
                " умиротворения и  вот этой гармонии, от слияния с бесконечно вечным," +
                " от созерцания  великого фрактального подобия и от вот этого " +
                "замечательного" +
                " всеединства  существа, бесконечно вечного, куда ни посмотри, " +
                "хоть вглубь - бесконечно  малое, хоть ввысь - бесконечное большое," +
                " понимаешь? А ты мне опять со  своим вот этим, иди суетись дальше," +
                " это твоё распределение, это  твой путь и твой горизонт познания " +
                "и ощущения твоей природы, он  несоизмеримо мелок по сравнению с" +
                " моим, понимаешь? Я как будто бы уже  давно глубокий старец, " +
                "бессмертный, ну или там уже почти бессмертный,  который на " +
                "этой планете от её самого зарождения, ещё когда только " +
                "Солнце  только-только сформировалось как звезда, " +
                "и вот это газопылевое облако,  вот, после взрыва, " +
                "Солнца, когда оно вспыхнуло, как звезда, начало  формировать " +
                "вот эти коацерваты, планеты, понимаешь, я на этой Земле уже  как " +
                "будто почти пять миллиардов лет живу и знаю её вдоль и поперёк  этот " +
                "весь мир, а ты мне какие-то... мне не важно на твои тачки, на твои  яхты," +
                " на твои квартиры, там, на твоё благо. Я был на этой  планете бесконечным " +
                "множеством, и круче Цезаря, и круче Гитлера, и круче  всех великих, " +
                "понимаешь, был, а где-то был конченым говном, ещё хуже,  чем здесь." +
                " Я множество этих состояний чувствую. Где-то я был больше  подобен " +
                "растению, где-то я больше был подобен птице, там, червю, где-то  был" +
                " просто сгусток камня, это всё есть душа, понимаешь? Она имеет " +
                "грани  подобия совершенно многообразные, бесконечное множество." +
                " Но тебе этого  не понять, поэтому ты езжай себе , мы в " +
                "этом мире как бы живем  разными ощущениями и разными " +
                "стремлениями, соответственно, разное наше и  место, " +
                "разное и наше распределение. Тебе я желаю все самые крутые " +
                "тачки  чтоб были у тебя, и все самые лучше самки, если мало идей, " +
                "обращайся ко мне, я тебе на каждую твою идею предложу сотню триллионов, как всё делать." +
                " Ну а я всё, я иду как глубокий старец,узревший вечное, прикоснувшийся к Божественному, сам " +
                "стал богоподобен и устремлен в это бесконечное, и который в умиротворении, покое, " +
                "гармонии, благодати, в этом сокровенном блаженстве пребывает, вовлеченный во всё и во " +
                "вся, понимаешь, вот и всё, в этом наша разница. Так что я иду любоваться мирозданием, а ты " +
                "идёшь преисполняться в ГРАНЯХ каких-то, вот и вся разница, понимаешь, ты не зришь " +
                "это вечное бесконечное, оно тебе не нужно. Ну зато ты, так сказать, более активен, как " +
                "вот этот дятел долбящий, или муравей, который очень активен в своей стезе, поэтому давай, " +
                "наши пути здесь, конечно, имеют грани подобия, потому что всё едино, но я-то тебя " +
                "прекрасно понимаю, а вот ты меня - вряд ли, потому что я как бы тебя в себе содержу, " +
                "всю твою природу, она составляет одну маленькую там песчиночку, от того что есть во мне, " +
                "вот и всё, поэтому давай, ступай, езжай, а я пошел наслаждаться прекрасным осенним " +
                "закатом на берегу теплой южной реки. " +
                "Всё, ступай, и я пойду. " +
                "", "Справка о себе", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }



        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Size_Click(object sender, KeyEventArgs e)
        {
            if (float.TryParse(Size.Text, out var size))
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, size);
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ////запись настроек
            //Properties.Settings.Default.BackgroundColor = this.BackColor;
            //Properties.Settings.Default.FormWidth = this.Width;
            //Properties.Settings.Default.FormHeight = this.Height;
            //Properties.Settings.Default.FormFont = this.Font;
            ////сохранение настроек
            Properties.Settings.Default.Save();
            if (richTextBox1.Text[0] == '*')
                NeedSave(sender, e);
        } // Закрытие Формы

        private void Form1_Load(object sender, EventArgs e)
        {
            ////загружаем фоновый цвет
            //this.BackColor = Properties.Settings.Default.BackgroundColor;
            ////загружаем шрифт
            //this.Font = Properties.Settings.Default.FormFont;
            ////загружаем размеры окна
            //this.Width = Properties.Settings.Default.FormWidth;
            //this.Height = Properties.Settings.Default.FormHeight;
        }




        #endregion Help

        // ^ Справка
    }
}