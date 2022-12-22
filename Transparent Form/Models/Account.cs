using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Transparent_Form.Models;

namespace Transparent_Form
{
    public class Account
    {
        DBconnect connect = new DBconnect();

        #region Properties
        private int _accId;
        public int accId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        private string _username;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private int _type;
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _accFirstName;
        public string accFirstName
        {
            get { return _accFirstName; }
            set { _accFirstName = value; }
        }

        private string _accLastName;
        public string accLastName
        {
            get { return _accLastName; }
            set { _accLastName = value; }
        }

        private DateTime _birthdate;
        public DateTime birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        private string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _phone;
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private object _photo;
        public object photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        #endregion Properties

        #region Student

        // to get student table and is also a function for any command in studentDb
        public DataTable GetStudentList(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string GetNumberOfStudents()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM account WHERE Type = 2").ToString();
        }

        public string GetNumberOfMaleStudents()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM account WHERE `Gender`='Male' AND Type = 2").ToString();
        }

        public string GetNumberOfFemaleStudents()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM account WHERE `Gender`='Female' AND Type = 2").ToString();
        }

        public DataTable SearchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT AccId, AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account` WHERE CONCAT(`AccFirstName`,`AccLastName`,`Address`) LIKE '%" + searchdata + "%' AND Type = 2", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `account`(`Type`, `AccFirstName`, `AccLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@t, @fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.GetConnection);
                   
            command.Parameters.Add("@t", MySqlDbType.Int32).Value = 2;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                return SetUsername();
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }

        private bool SetUsername()
        {
            string username = "student.";
            int id = (int)DataProvider.Instance.ExecuteScalar("SELECT max(AccId) FROM `account`");
            username += id.ToString() ;
            MySqlCommand command2 = new MySqlCommand("UPDATE account SET Username = @usr WHERE AccId = @id; ", connect.GetConnection);
            command2.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.OpenConnect();
            if (command2.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                _username = username;
                _password = "123456";
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }

        public bool UpdateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.GetConnection);

            //@id,@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
        #endregion Student
                
        #region Account
        public bool InsertAccount(string usr, int type, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img, int id = 0)
        {
            //  if (id == 0)
            MySqlCommand command = new MySqlCommand("INSERT INTO `account`(`Username`, `Type`, `AccFirstName`, `AccLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@usr, @t, @fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.GetConnection);

            //@usr, @t, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usr;
            command.Parameters.Add("@t", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                _username = usr;
                _password = "123456";
                _type = type;
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }

        public bool UpdateAccount(int id, string usr, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `Username`=@usr, `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.GetConnection);

            //@id, @usr, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usr;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
              
        public bool DeleteAccount(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `account` WHERE `AccId`=@id", connect.GetConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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
        #endregion Account

        #region MyAccount
        public bool GetMyAccount(string query)
        {
            Account account = new Account();
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.OpenConnect();

            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return false;
            }


            do
            {
                this._accId = (int)reader[0];
                this._username = reader[1].ToString();
                this._password = reader[2].ToString();
                this._type = (int)reader[3];
                this._accFirstName = reader[4].ToString();
                this._accLastName = reader[5].ToString();
                this._birthdate = (DateTime)reader[6];
                this._gender = reader[7].ToString();
                this._phone = reader[8].ToString();
                this._address = reader[9].ToString();
                if (reader[10] != DBNull.Value)
                {
                    this._photo = (byte[])reader[10];
                }

            } while (reader.Read());
            reader.Close();
            connect.CloseConnect();
            return true;

        }

        public bool UpdateMyAccount(string fname, string lname, DateTime birthdate, string gender, string phone, string address, object photo)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.GetConnection);

            //@id, @usr, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _accId;         
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = photo;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();

                _accFirstName = fname;
                _accLastName = lname;
                _birthdate = birthdate;
                _gender = gender;
                _phone = phone;
                _address = address;
                _photo = photo;

                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }

        public bool UpdatePassword(string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `Password`=@pass WHERE  `AccId`= @id", connect.GetConnection);

            //@id, @pass
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _accId;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                _password = pass;
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }
        }
        #endregion MyAccount
           
    }
}
