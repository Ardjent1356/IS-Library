using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Takenbooktable : Form
    {
        public Takenbooktable()
        {
            InitializeComponent();
        }

        private void taken_booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taken_booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Takenbooktable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet1.Books". При необходимости она может быть перемещена или удалена.
            //this.booksTableAdapter1.Fill(this.bibliotecaDataSet1.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bibliotecaDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Taken_books". При необходимости она может быть перемещена или удалена.
            this.taken_booksTableAdapter.Fill(this.bibliotecaDataSet.Taken_books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Производит фильтрацию данных
            taken_booksBindingSource.Filter = "ID_Taken_books='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Осуществляет отмену фильтрации
            taken_booksBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Осуществляет поиск по ячейкам
            for (int i = 0; i < taken_booksDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < taken_booksDataGridView.RowCount - 1; j++)
                {
                    taken_booksDataGridView[i, j].Style.BackColor = Color.White;
                    taken_booksDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < taken_booksDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < taken_booksDataGridView.RowCount - 1; j++)
                {
                    if (taken_booksDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        taken_booksDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        taken_booksDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Закрывает форму, тем самым возвращает нас на основную форму
            this.Close();
        }
    }
}
