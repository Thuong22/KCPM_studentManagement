using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form
{
    class Score
    {
        DBconnect connect = new DBconnect();

        public DataTable GetScoreList(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool CheckScore(int stdId, int cId)
        {
            DataTable table = GetScoreList("SELECT * FROM `score` WHERE `StudentId`= '" + stdId + "' AND `CourseId`= '" + cId + "'");
            if (table.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }

        public bool InsertScore(int stdid, int courid)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`, `CourseId`) VALUES (@stid,@cid)", connect.GetConnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courid;

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

        public bool UpdateScore(int stdid, int scid, Nullable<double> scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sco,`Description`=@desc WHERE `StudentId`=@stid AND `CourseId`=@scid", connect.GetConnection);
            command.Parameters.Add("@scid", MySqlDbType.Int32).Value = scid;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = scor;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
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

        public bool DeleteScore(int sid, int cid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId`=@sid AND `CourseId`=@cid", connect.GetConnection);
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = sid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid;

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
    }
}
