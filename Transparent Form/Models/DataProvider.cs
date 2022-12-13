using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form.Models
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        DBconnect connect = new DBconnect();

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.OpenConnect();
            var data = command.ExecuteScalar();
            connect.CloseConnect();
            return data;
        }
    }
}