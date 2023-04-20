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
    public partial class Readertable : Form
    {
        public Readertable()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Readertable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.bibliotecaDataSet.Reader);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            readerBindingSource.Filter = "FIO_Reader='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readerBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < readerDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < readerDataGridView.RowCount - 1; j++)
                {
                    readerDataGridView[i, j].Style.BackColor = Color.White;
                    readerDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < readerDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < readerDataGridView.RowCount - 1; j++)
                {
                    if (readerDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        readerDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        readerDataGridView[i, j].Style.ForeColor = Color.Blue;

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
