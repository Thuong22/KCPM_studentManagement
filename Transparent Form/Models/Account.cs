using MySql.Data.MySqlClient;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form.Models
{
    public class Account
    {
        DBconnect connect = new DBconnect();

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type { get; set; }

        public Account() { }

        public Account(string id, string user, string pass, string type)
        {
            this.id = int.Parse(id);
            this.username = user;
            this.password = pass;
            this.type = int.Parse(type);
        }

        public Account GetAccount(string user, string pass)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + user + "' AND `password`= '" + pass + "'");
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                Account account = new Account(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString());
                return account;
            }
            return null;
        }
    }
}
