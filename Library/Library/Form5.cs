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
    public partial class Taken_books : Form
    {
        private Menu menu;
        private Takenbooktable takenbooktable;
        public Taken_books()
        {
            InitializeComponent();
        }

        private void taken_booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taken_booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

    private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.bibliotecaDataSet.Reader);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bibliotecaDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet1.Taken_books". При необходимости она может быть перемещена или удалена.
            //this.taken_booksTableAdapter1.Fill(this.bibliotecaDataSet1.Taken_books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Taken_books". При необходимости она может быть перемещена или удалена.
            this.taken_booksTableAdapter.Fill(this.bibliotecaDataSet.Taken_books);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taken_booksBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taken_booksBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taken_booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            takenbooktable = new Takenbooktable();
            takenbooktable.Visible = true;
        }
    }
}
