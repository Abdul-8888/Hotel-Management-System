using HMS_v1.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS_v1.DL
{
    public class CustomerDL
    {
        public static Customer current;

        public static bool addCustomer(Customer customer)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@personId", SqlDbType.Int).Value = customer.PersonId;

                int id = LookUpDL.retrieveLookUp("Account", "active");
                cmd.Parameters.Add("@account", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool removeCustomer(int customerId)
        {
            //try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Customer";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Account";

                int id = LookUpDL.retrieveLookUp("Account", "deactive");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "CustomerId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = customerId;

                cmd.ExecuteNonQuery();

                return true;
            }
            //catch
            {
                return false;
            }
        }

        public static bool updateCustomer(Customer newCustomer)
        {
            Customer prevCustomer = current;

            //try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevCustomer.Username != newCustomer.Username)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Username = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Username);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.Password != newCustomer.Password)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Password = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Password);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.Cnic != newCustomer.Cnic)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Cnic = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Cnic);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.FirstName != newCustomer.FirstName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set FirstName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.FirstName);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.LastName != newCustomer.LastName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set LastName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.LastName);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.MiddleName != newCustomer.MiddleName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set MiddleName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.MiddleName);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.DateOfBirth != newCustomer.DateOfBirth)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set DateOfBirth = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.DateOfBirth);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.Gender != newCustomer.Gender)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Gender = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Gender);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.Email != newCustomer.Email)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Email = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Email);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevCustomer.Phone != newCustomer.Phone)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Phone = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newCustomer.Phone);
                    cmd.Parameters.AddWithValue("@id", newCustomer.PersonId);
                    cmd.ExecuteNonQuery();
                }

                current = retrieveCustomer(newCustomer.CustomerId);

                return true;
            }
            //catch
            {
                return false;
            }
        }

        public static Customer retrieveCustomer(int customerid)
        {
            string username = "";
            string password = "";
            string cnic = "";
            string firstName = "";
            string lastName = "";
            string middleName = "";
            DateTime dateOfBirth = DateTime.Today;
            int gender = 0;
            string email = "";
            string phone = "";
            int role = 0;

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd1 = new SqlCommand("Select PersonId From Customer Where CustomerId = @id", con);
            cmd1.Parameters.AddWithValue("@id", customerid);

            int personId = int.Parse(cmd1.ExecuteScalar().ToString());
            
            cmd1.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("Select * From Person Where PersonId = @id", con);
            cmd.Parameters.AddWithValue("@id", personId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                username = reader.GetString(1);
                password = reader.GetString(2);
                cnic = reader.GetString(3);
                firstName = reader.GetString(4);
                lastName = reader.GetString(5);
                middleName = reader.GetString(6);
                dateOfBirth = reader.GetDateTime(7);
                gender = reader.GetByte(8);
                email = reader.GetString(9);
                phone = reader.GetString(10);
                role = reader.GetByte(11);
            }
            reader.Close();

            cmd.ExecuteNonQuery();

            LookUp gen = LookUpDL.retrieveLookUp((int)gender);
            LookUp ro = LookUpDL.retrieveLookUp((int)role);

            Customer c = new Customer(personId, customerid,username,password,double.Parse(cnic),firstName,lastName,middleName,dateOfBirth,gen.Value,email,double.Parse(phone),ro.Value);
            current = c;
            return c;
        }

        public static DataTable retrieveCustomer()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Person As p Join Customer As c On p.PersonId = c.PersonId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            return dt;
        }

        public static bool getCustomerType()/////////////////////masla yaha ha
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(RoomBookingId) From CustomerRoom Where CustomerId = @cId And CheckIn Is Null ", con);
            cmd.Parameters.AddWithValue("@cId", current.CustomerId);

            int isExist = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.BeginExecuteNonQuery();

            if (isExist > 0)
            {
                return true;
            }
            return false;
        }
    }
}
