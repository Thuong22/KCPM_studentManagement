using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace Transparent_Form
{
    class AccountClass
    {
        public  static AccountClass account = new AccountClass();
        DBconnect connect = new DBconnect();

        #region properties
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
        #endregion properties

        #region student

        //create a function to add a new students to the database
        //when adding a new student, a new account also will be created for this student
        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {            
            MySqlCommand command = new MySqlCommand("INSERT INTO `account`(`Type`, `AccFirstName`, `AccLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@t, @fn, @ln, @bd, @gd, @ph, @adr, @img)",connect.getconnection);

            //@t, @fn, @ln, @bd, @gd, @ph, @adr, @img
            //mặc định account type = 2(student)
            command.Parameters.Add("@t", MySqlDbType.Int32).Value = 2; 
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                return setUsername();
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

        //set and add username for acc of student    
        private bool setUsername()
        {
            string username = "student.";
            string id = getOneValueFromTable("SELECT max(AccId) FROM `account`");
            username += id;
            MySqlCommand command2 = new MySqlCommand("UPDATE account SET Username = @usr WHERE AccId = @id; ", connect.getconnection);
            command2.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(id);
            connect.openConnect();
            if (command2.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                _username = username;
                _password = "123456";
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }



        // to get student table and is also a function for any command in studentDb
        public DataTable getList(MySqlCommand command)
        {
            command.Connection=connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string getOneValueFromTable(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string value = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return value;
        }
        //to get the total student
        public string totalStudent()
        {
            return getOneValueFromTable("SELECT COUNT(*) FROM account WHERE Type = 2");
        }
        // to get the male student count
        public string maleStudent()
        {
            return getOneValueFromTable("SELECT COUNT(*) FROM account WHERE `Gender`='Male' AND Type = 2");
        }
        // to get the female student count
        public string femaleStudent()
        {
            return getOneValueFromTable("SELECT COUNT(*) FROM account WHERE `Gender`='Female' AND Type = 2");
        }
        //create a function search for student (first name, last name, address)
        public DataTable searchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT AccId, AccFirstName, AccLastName, Birthdate, Gender, Phone, Address, Photo FROM `account` WHERE CONCAT(`AccFirstName`,`AccLastName`,`Address`) LIKE '%" + searchdata +"%' AND Type = 2", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       //create a function edit for student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.getconnection);

            //@id,@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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

        #endregion student

        #region account
       
        public bool insertAccount(string usr, int type, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img, int id = 0)
        {
            //  if (id == 0)
            MySqlCommand command = new MySqlCommand("INSERT INTO `account`(`Username`, `Type`, `AccFirstName`, `AccLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@usr, @t, @fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.getconnection);

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

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                _username = usr;
                _password = "123456";
                _type = type;
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool updateAccount(int id, string usr, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `Username`=@usr, `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.getconnection);

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
       
        //Create a function to delete data
        //we need only id 
        public bool deleteAccount(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `account` WHERE `AccId`=@id", connect.getconnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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

        #endregion account

        #region myAccount
        public bool getMyAccount (string query)
        {
            AccountClass account = new AccountClass();
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();

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
            connect.closeConnect();
            return true;

        }

        public bool updateMyAccount ()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `Username`=@usr, `AccFirstName`=@fn,`AccLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `AccId`= @id", connect.getconnection);

            //@id, @usr, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _accId;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = _username;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = _accFirstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = _accLastName;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = _birthdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = _gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = _phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = _address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = _photo;

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

        public bool updatePassword(string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `account` SET `Password`=@pass WHERE  `AccId`= @id", connect.getconnection);

            //@id, @pass
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _accId;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                _password = pass;
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        #endregion myAccount
    }
}
