using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Windows.Forms;
using HMS_v1.BL;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_v1
{
    public class validation
    {
        public static string NameRegex = "^[A-Za-z]{1,11}$";

        public static string CNICRegex = "^[0-9]{13,13}$";

        public static string PasswordRegex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*#?&]{8,20}$";

        public static string UsernameRegex = @"^[a-zA-Z0-9_-]{3,16}$";

        public static string EmailRegex = "^\\S+@\\S+\\.\\S+$";
        public static string GenderRegex = "^M(ale)?$|^F(emale)?$|^(Other)?$";
        public static string ContactRegex = "^[0-9]{11,11}$";
        public static string RegNoRegex = "^[0-9]{1,4}-[A-Za-z]{2}-[0-9]{1,3}$";
        public static string SalaryRegex = "^[0-9]{1,}$";
        public static string numberRegex = "^[0-9]{1,}$";
        
        public static bool CheckJobRole (string role)
        {
            /*var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count()", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@unitPrice", SqlDbType.Int).Value = product.UnitPrice;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = product.Name;*/
            return true;
        }

        public static bool CheckProType (string product)
        {
            return true;
        }

        public static bool CheckRoom (string room)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Value) From LookUp Where Category = \'Room Type\' and Value = @val", con);
            cmd.Parameters.AddWithValue("@val", room);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            /*SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                isExist = reader.GetInt32(0);
            }

            reader.Close();*/
            cmd.ExecuteNonQuery();
            //con.Close();

            if (isExist > 0)
            {
                return true;
            }

            return false; return true;
        }

        public static bool CheckAvailability (string status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Value) From LookUp Where Category = \'Availability\' and Value = @val", con);
            cmd.Parameters.AddWithValue("@val", status);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            /*SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                isExist = reader.GetInt32(0);
            }

            reader.Close();*/
            cmd.ExecuteNonQuery();
            //con.Close();

            if (isExist > 0)
            {
                return true;
            }

            return false;
        }

        public static bool CheckNumber (string number)
        {
            return Regex.IsMatch(number, numberRegex);
        }

        public static bool CheckCnic (string cnic)
        {
            return Regex.IsMatch(cnic, CNICRegex);
        }
        public static bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, PasswordRegex);
        }

        public static bool CheckObtainMarks(string obtainmarks)
        {
            return true;
        }
        public static bool Checkweightage(string weightage)
        {
            return true;
        }

        public static bool CheckMarks(string Marks)
        {
            return true;
        }
        public static bool CheckSalary(string salary)
        {
            return Regex.IsMatch(salary, SalaryRegex);
        }
        public static bool CheckRegNo( string RegNo )
        {
            return Regex.IsMatch(RegNo, RegNoRegex);
        }
        public static bool CheckDesignation(string Designation)
        {
            return true;
        }

        public static bool CheckEmail( string Email )
        {
            return Regex.IsMatch ( Email, EmailRegex );
        }
        public static bool CheckContact( string rate )
        {
            return Regex.IsMatch(rate, ContactRegex);
        }

        public static bool CheckGender(string gender)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Value) From LookUp Where Category = 'Gender' and Value = @val", con);
            cmd.Parameters.AddWithValue("@val", gender);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            /*SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                isExist = reader.GetInt32(0);
            }

            reader.Close();*/
            cmd.ExecuteNonQuery();
            //con.Close();

            if(isExist > 0)
            {
                return true;
            }

            return false;
        }

        public static bool CheckName (string name)
        {
            return Regex.IsMatch(name, NameRegex);
        }
        public static bool CheckUsername(string name)
        {
            return Regex.IsMatch(name, UsernameRegex);
        }

        public static bool usernameExist(string username)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Username) From Person Where Username = @u", con);
            cmd.Parameters.AddWithValue("@u", username);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            if(isExist > 0)
            {
                return true;
            }
            return false;
        }

        public static bool cnicExist(string c)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(CNIC) From Person Where CNIC = @u", con);
            cmd.Parameters.AddWithValue("@u", c);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            if (isExist > 0)
            {
                return true;
            }
            return false;
        }

        public static bool emailExist(string email)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Email) From Person Where Email = @u", con);
            cmd.Parameters.AddWithValue("@u", email);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            if (isExist > 0)
            {
                return true;
            }
            return false;
        }

        public static bool phoneExist(string p)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(Phone) From Person Where Phone = @u", con);
            cmd.Parameters.AddWithValue("@u", p);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            if (isExist > 0)
            {
                return true;
            }
            return false;
        }

        public static bool roomExist(string r)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(RoomNo) From Room Where RoomNo = @u", con);
            cmd.Parameters.AddWithValue("@u", r);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            if (isExist > 0)
            {
                return true;
            }
            return false;

        }
    }
}
