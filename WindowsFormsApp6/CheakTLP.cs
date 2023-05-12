using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class CheakTLP : Form
    {
        private Panel currentPanel;
        private Point originalMousePos;
        private Point originalPanelPos;
        ContextMenuStrip menu;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\fakk\\WindowsFormsApp6\\Database2.mdf;Integrated Security=True";
        public CheakTLP()
        {
            InitializeComponent();
            // Создаем контекстное меню
            menu = new ContextMenuStrip();
            // Добавляем пункт меню
            menu.Items.Add("★★★★★");
            menu.Items.Add("★★★★");
            menu.Items.Add("★★★");
            menu.Items.Add("★★");
            menu.Items.Add("★");
            menu.Items.Add(string.Empty);

            menu.Items[0].Click += Five_Click;
            menu.Items[1].Click += Four_Click;
            menu.Items[2].Click += Three_Click;
            menu.Items[3].Click += Two_Click;
            menu.Items[4].Click += One_Click;
            dataGridView1.ContextMenuStrip = menu;
        }
        private void Five_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = "★★★★★";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = "★★★★";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = "★★★";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = "★★";
        }
        private void One_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = "★";
        }
        public void FastTry()
        {
            decimal d = 0.111M;
            string query = "INSERT INTO Books (Rating, Name) VALUES (@FloatValue, N'Pivo');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FloatValue", d);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
        }
        public void ImportCsvToDatabase(string filePath, string connectionString)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();


                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            try
                            {
                                var line = reader.ReadLine()
                                .Replace(", #", " #")
                                .Replace("'", "")
                                .Replace("\"", "");


                                var values = line.Split(',');
                                string BookTitle;
                                if (values[1].Length > 50)
                                    BookTitle = values[1].Substring(0, 50);
                                else
                                    BookTitle = values[1];
                                var Author = values[12];
                                //var test = decimal.Parse("2.1");
                                var Rating = decimal.Parse(values[13].Replace(".", ","));
                                var Language = values[11];
                                var Num_pages = int.Parse(values[3]);
                                var publication_date = values[10];
                                var publisher = values[8];


                                var command = new SqlCommand("INSERT INTO Books (Name, Author, Date_of_release, Rating, Publisher, Language, Num_pages) " +
                                                              $"VALUES (N'{BookTitle}', N'{Author}', N'{publication_date}', @Rating, N'{publisher}', N'{Language}',@Num)", connection);

                                command.Parameters.Add("Rating", SqlDbType.Decimal).Value = Rating;
                                command.Parameters.Add("Num", SqlDbType.Int).Value = Num_pages;
                                command.ExecuteNonQuery();
                                //MessageBox.Show($"{BookTitle}, {Author}, {Rating}, {Language}, {Num_pages}, {publication_date}, {publisher}");
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message );
                                //MessageBox.Show($"{BookTitle}, {Author}, {Rating}, {Language}, {Num_pages}, {publication_date}, {publisher}");
                            }

                        }
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    //transaction.Rollback();
                    throw ex;
                }

            }


        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            currentPanel = (Panel)sender;
            originalMousePos = e.Location;
            originalPanelPos = currentPanel.Location;
            currentPanel.Focus();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            currentPanel = (Panel)sender;
            originalMousePos = e.Location;
            originalPanelPos = currentPanel.Location;
            currentPanel.Focus();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            currentPanel = (Panel)sender;
            originalMousePos = e.Location;
            originalPanelPos = currentPanel.Location;
            currentPanel.Focus();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MovePanel(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MovePanel(sender, e);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            MovePanel(sender, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            currentPanel = null;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            currentPanel = null;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            currentPanel = null;
        }

        private void MovePanel(object sender, MouseEventArgs e)
        {
            if (currentPanel != null && e.Button == MouseButtons.Left)
            {
                int deltaX = e.Location.X - originalMousePos.X;
                int deltaY = e.Location.Y - originalMousePos.Y;
                int newX = originalPanelPos.X + deltaX;
                int newY = originalPanelPos.Y + deltaY;
                currentPanel.Location = new Point(newX, newY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("fsa", "asf", "zalupa", "asdfa");
            ImportCsvToDatabase("C:\\Users\\Никита\\Desktop\\book1-100k.csv", "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\fakk\\WindowsFormsApp6\\Database2.mdf;Integrated Security=True");
            //FastTry();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = dataGridView1.CurrentCell;

            Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            // Выводим координаты прямоугольника в заголовок формы
            this.Text = $"Координаты ячейки: ({rect.X}, {rect.Y})";

            // Получаем позицию выбранной ячейки
            int rowIndex = selectedCell.RowIndex;
            int columnIndex = selectedCell.ColumnIndex;

            Point cellLocation = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
            Point locationOnForm = dataGridView1.FindForm().PointToClient(dataGridView1.Parent.PointToScreen(dataGridView1.Location));
            Point cellLocationOnForm = new Point(cellLocation.X + locationOnForm.X, cellLocation.Y + locationOnForm.Y);

            // Определяем позицию, где был произведен щелчок мыши
            int currentMouseOverRow = dataGridView1.HitTest(cellLocation.X, cellLocation.Y).RowIndex;
            int currentMouseOverColumn = dataGridView1.HitTest(cellLocation.X, cellLocation.Y).ColumnIndex;
            int rowCount = dataGridView1.RowCount - 1;
            bool trorf = currentMouseOverRow != rowCount; // Проверяем выбрана последняя ячейка или нет
            // Если щелчок был произведен на ячейке DataGridView
            if (currentMouseOverRow >= 0 && currentMouseOverColumn >= 0 && selectedCell.ColumnIndex==4 && trorf)
            {
                // Показываем контекстное меню в точке, где был произведен щелчок мыши
                menu.Show(dataGridView1, new Point(rect.X, rect.Y+25));
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridView1.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedColumns[0].Index == 1 )
            {
                
            }
        }
    }
}