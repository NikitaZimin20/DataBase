using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class DeleteClass:DataBase
    {
        public DeleteClass(string ID)
        {
            persons.ID = ID;
        }
        private DeleteClass()
        {

        }
        PersonsInfo persons = new PersonsInfo();
        
        public void Delete()
        {
            DeleteClass delete = new DeleteClass();
            delete.Open("DELETE FROM Base WHERE ID='"+persons.ID+"'");
        }
    }
}
