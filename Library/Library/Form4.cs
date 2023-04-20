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
    public partial class Reader : Form
    {
        private Menu menu;
        private Readertable readertable;
        public Reader()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void readerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotecaDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.bibliotecaDataSet.Reader);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readerBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readertable = new Readertable();
            readertable.Visible = true;
        }
    }
}
