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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("1");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("2");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("3");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("4");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("5");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("6");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked == true) { listBox4.Items.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { listBox4.Items.Add(checkBox2.Text); }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
    }
}
