using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form
{
    class ScoreClass
    {
        DBconnect connect = new DBconnect();

        public bool insertScore(int stdid, int courid)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`, `CourseId`) VALUES (@stid,@cid)", connect.getconnection);
            //@stid,@cn,@sco,@desc
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courid;
            
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkScore(int stdId, int cId)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `StudentId`= '" + stdId + "' AND `CourseId`= '" + cId + "'"));
            if (table.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }

        public bool updateScore(int stdid, int scid, Nullable<double> scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sco,`Description`=@desc WHERE `StudentId`=@stid AND `CourseId`=@scid", connect.getconnection);
            command.Parameters.Add("@scid", MySqlDbType.Int32).Value = scid;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = scor;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool deleteScore(int sid, int cid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId`=@sid AND `CourseId`=@cid", connect.getconnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = sid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
