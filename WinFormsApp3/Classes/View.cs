using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class View:DataBase
    {
        public View()
        {

        }
        
        public DataTable ShowTable()
        {
            View view = new View();
            return view.Open("SELECT * FROM Base");
        }
    }
}
