using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string syad = textBox2.Text;
            listBox1.Items.Add(ad+" "+syad);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = listBox1.SelectedIndex;
            if (sec != -1)
            {
                listBox1.Items.RemoveAt(sec);
            }
            else
                MessageBox.Show("Seçim Yapınız...");
        }
     
        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
