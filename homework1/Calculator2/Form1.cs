using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        int num1,num2;
        string outcome;
        bool text1=false,text2=false;
        //num1=int.Parse(textBox1.Text);
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            if (textBox1.Text != "") text1 = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox2.Text);
            if (textBox2.Text != "") text2 = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (text1 && text2)
            {
                outcome = $"{num1 + num2}";
            }
            else outcome = "error";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (text1 && text2)
            {
                outcome = $"{num1 - num2}";
            }
            else outcome = "error";
        }


        private void multi_Click(object sender, EventArgs e)
        {
            if (text1 && text2)
            {
                outcome = $"{num1 * num2}";
            }
            else outcome = "error";
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (text1 && text2)
            {
                if (num2 == 0) outcome = "error";
                else outcome = $"{num1 / num2}";
            }
            else outcome = "error";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            label3.Text = outcome;
        }
    }
}
