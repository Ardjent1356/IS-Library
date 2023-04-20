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
    public partial class BookTable : Form
    {
        public BookTable()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bibliotecaDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "Name_Book='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < booksDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < booksDataGridView.RowCount - 1; j++)
                {
                    booksDataGridView[i, j].Style.BackColor = Color.White;
                    booksDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < booksDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < booksDataGridView.RowCount - 1; j++)
                {
                    if (booksDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        booksDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        booksDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
