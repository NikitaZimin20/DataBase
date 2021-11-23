using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class ForFind:DataBase
    {
        PersonsInfo persons = new PersonsInfo();
       public ForFind(string stroka )
        {
            this.stroka = stroka;

        }
        private ForFind()
        {

        }
       
        string stroka { get; set; }
        public DataTable Find()
        {
            ForFind find = new ForFind();
            DataBase data = new DataBase();
           return find.Open("SELECT * FROM Base WHERE ID='"+stroka+"' OR FirstName='"+stroka+"' OR LastName='"+stroka+
                "' OR MiddleName='"+stroka+"' OR Phone='"+stroka+"' OR Address='"+stroka+"' OR Notes='"+stroka+"'");
        } 
    }
    
}
