using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.CurrentDirectory}\\Students_PM.txt";
            StreamWriter writer = new StreamWriter(path,true); 
            writer.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            writer.Flush();
            writer.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                string path = $"{Environment.CurrentDirectory}\\Students_PM.txt";
                dataGridView1.Rows.Clear();
                StreamReader reader = new StreamReader(path);
                string rows = reader.ReadLine();
                while (rows != null)
                {
                    string[] studentinfo = rows.Split(' ');
                    dataGridView1.Rows.Add(studentinfo);
                    rows = reader.ReadLine();
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "New TabPage";
                tabControl1.TabPages.Add(tabPage);
            }
        }
    }
}
