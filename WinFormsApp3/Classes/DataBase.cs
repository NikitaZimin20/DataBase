
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace WinFormsApp3
{
    class DataBase
    {
        SQLiteConnection connection;
        string sourse="mydb.db";
      
        protected DataTable Open(string quary)
        {
            if (Connect(sourse))
            {
               return FillData(quary);
            }
            return null;
        }
        private bool Connect(string fileName)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + fileName );
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }
        private DataTable FillData(string query)
        {
          
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query,connection);
            var table = new DataTable();
            adapter.Fill(table);
            return table;

        }

    }
}
