using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked)
        //    {
        //        Form1 form1 = new Form1();
        //        form1.textBox1.ReadOnly = false;
        //        form1.textBox2.ReadOnly = false;
        //        form1.textBox2.ReadOnly = false;
        //    }
        //    else if (radioButton2.Checked)
        //    {
        //        Form1 f1 = new Form1();
        //        f1.textBox1.ReadOnly = true;
        //        f1.textBox2.ReadOnly = true;
        //        f1.textBox3.ReadOnly = true;
        //    }

        //}


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                f1.textBox1.ReadOnly = false;
                f1.textBox2.ReadOnly = false;
                f1.textBox3.ReadOnly = false;
            }
            else if (radioButton2.Checked)
            {
                f1.textBox1.ReadOnly = true;
                f1.textBox2.ReadOnly = true;
                f1.textBox3.ReadOnly = true;
            }
            Close();
        }
    }
}
