using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string V = "hello ";

        public Form1()
        {
            InitializeComponent();
        }

        private void لغو_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Next_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblinteryourname_MouseMove(object sender, MouseEventArgs e)
        {
            lblinteryourname.ForeColor = Color.Red;
        }

        private void lblinteryourname_MouseLeave(object sender, EventArgs e)
        {
            lblinteryourname.ForeColor = Color.Black;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {

            string s;
            s = "hello" + textBox1.Text;
            lblresult.Text = s;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblresult.Text = "";
            textBox1.Focus();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                btnsayhello.Enabled = false;
            else
                btnsayhello.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                    btnsayhello.Enabled = false;
                else
                    btnsayhello.Enabled = true;
            
        }

        }
    }
}
