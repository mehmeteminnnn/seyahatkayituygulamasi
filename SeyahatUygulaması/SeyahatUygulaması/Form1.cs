using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "1234")
            {
                Form2 fr=new Form2();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
