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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        MainWindow main = new MainWindow();
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteClass delete = new DeleteClass(textBox1.Text);
            delete.Delete();
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
