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
    public partial class Menu : Form
    {
        private Book book;
        private Reader reader;
        private Taken_books retur;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book = new Book();
            book.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader = new Reader();
            reader.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retur = new Taken_books();
            retur.Visible = true;
        }
    }
}
