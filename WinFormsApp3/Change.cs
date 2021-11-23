using System;

using System.Linq;

using System.Windows.Forms;


namespace WinFormsApp3
{
    public partial class ChangeClass : Form
    {

        public ChangeClass()
        {
            InitializeComponent();
          
        }     
        private void Change(CheckBox check)
        {
                var textBoxes = Controls.OfType<TextBox>();
                foreach (var item in textBoxes)
                {
                    if (item.Tag == check.Tag)
                    {
                        Flag(item);
                    }
                } 
        }
        private void Flag(TextBox text)
        {
            if (text.Enabled)
            {
                text.Enabled = false;
            }
            else text.Enabled = true;

        }
        MainWindow main = new MainWindow();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            var checkBoxes = Controls.OfType<TextBox>();
            ForChanges changes = new ForChanges(checkBoxes,ID);
            changes.Change();
            
            main.Visible = true;
            this.Close();

        }

        private void ChangeClass_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Change((CheckBox)sender) ;
        }
    }
}
