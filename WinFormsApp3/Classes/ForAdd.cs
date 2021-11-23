using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class ForAdd:DataBase
    {
        PersonsInfo persons = new PersonsInfo();        
        public ForAdd(string name,string lastname,string middlename,string adress,string phone,string notes)
        {
            persons.name = name;
            persons.lastname = lastname;
            persons.middlename = middlename;
            persons.adress = adress;
            persons.phone = phone;
            persons.notes = notes;

        }
       private ForAdd()
        {

        }
       
        
        
        public void AddNew()
        {
            ForAdd add = new ForAdd();
            add.Open("INSERT INTO Base(FirstName,LastName,MiddleName,Phone,Address,Notes) VALUES('"+ persons.name + "','"+ persons.lastname + 
                "','"+ persons.middlename + "','"+ persons.adress + "','"+ persons.phone + "','"+ persons.notes + "')");
        }
    }
}
