using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        MainWindow main = new MainWindow();
        private void button1_Click(object sender, EventArgs e)
        {   
            ForAdd command = new ForAdd(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
            command.AddNew();
            main.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Visible = true;
            this.Close();
        }
    }
}
