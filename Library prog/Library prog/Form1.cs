using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            MessageBox.Show("Succesfully added to list.");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == listBox1.Text)
                listBox1.Items.Clear();
            listBox1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            string b;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToString(textBox2.Text);
            if (a == 1384 && b == "farnood")
            {
                listBox1.Visible = true;
                textBox1.Visible = true;
                Add.Visible = true;
                Sort.Visible = true;
                Search.Visible = true;
                Clear.Visible = true;
                Remove.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else
                MessageBox.Show("Wrong Password/Username");
        }
    }
}
