using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(" ", " ");
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Запускаем стандартный режим редактирования ячейки DataGridView
            DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Проверяем, что ячейка не заблокирована для редактирования
            if (!selectedCell.ReadOnly)
            {
                // Завершаем редактирование предыдущей ячейки
                dataGridView1.EndEdit();

                // Запускаем редактирование выбранной ячейки
                dataGridView1.BeginEdit(true);
            }

        }
    }
}
