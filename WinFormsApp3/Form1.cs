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
    public partial class MainWindow : Form
    {
        DataBase data = new DataBase();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            View view = new View();
            dataGridView1.DataSource = view.ShowTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UselessVoid(Form form)
        {
            this.Visible = false;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForFind forFind = new ForFind(textBox1.Text);
            dataGridView1.DataSource = forFind.Find();
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            UselessVoid(form);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm();
            UselessVoid(form);
        }

        private void change_Click(object sender, EventArgs e)
        {
            ChangeClass form = new ChangeClass();
            UselessVoid(form);
        }
    }
}
