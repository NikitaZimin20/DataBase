using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    class ForChanges:DataBase
    {
        
        IEnumerable<TextBox> task;
        RichTextBox ID;

        public ForChanges(IEnumerable<TextBox>task,RichTextBox ID)
        {
            this.task = task;
            this.ID = ID;
        }
        private ForChanges()
        {

        }
        public void Change()
        {
            ForChanges ex = new ForChanges();
            foreach (var item in task)
            {
                if (item.Enabled)
                {
                    ex.Open("UPDATE Base SET '" + item.Name + "'='" + item.Text + "'WHERE ID='" + ID.Text + "'");
                }
            }
        }
    }
}
