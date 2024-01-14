using HMS_v1.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HMS_v1.DL
{
    public class PersonDL
    {
        public static bool addPerson(Employee e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertPerson", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = e.Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = e.Password;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = e.Cnic.ToString();
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = e.FirstName;
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = e.LastName;
                cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = e.MiddleName;
                cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = e.DateOfBirth;
                
                int id = LookUpDL.retrieveLookUp("Gender", e.Gender);
                cmd.Parameters.Add("@gender", SqlDbType.Int).Value = id;
                
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = e.Email;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = e.Phone.ToString();

                id = LookUpDL.retrieveLookUp("Role", e.Role);
                cmd.Parameters.Add("@role", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool addPerson(Customer e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertPerson", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = e.Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = e.Password;
                cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = e.Cnic.ToString();
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = e.FirstName;
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = e.LastName;
                cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = e.MiddleName;
                cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = e.DateOfBirth;

                MessageBox.Show(e.Gender);
                int id = LookUpDL.retrieveLookUp("Gender", e.Gender);
                cmd.Parameters.Add("@gender", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = e.Email;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = e.Phone.ToString();

                id = LookUpDL.retrieveLookUp("Role", e.Role);


                cmd.Parameters.Add("@role", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int getId()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select Max(PersonId) From Person", con);

            int id = (int)cmd1.ExecuteScalar();

            cmd1.ExecuteNonQuery();

            return id;
        }

        public static string checkPerson(string username, string password)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select Count(Username) From Person Where Username = @u And Password = @p", con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                int isExist = int.Parse(cmd.ExecuteScalar().ToString());

                cmd.ExecuteNonQuery();

                if (isExist > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Select PersonId, Role From Person Where Username = @u And Password = @p", con);
                    cmd1.Parameters.AddWithValue("@u", username);
                    cmd1.Parameters.AddWithValue("@p", password);

                    byte role = 0; //int.Parse(cmd1.ExecuteScalar().ToString());
                    int pId = 0;

                    SqlDataReader reader = cmd1.ExecuteReader();
                    if(reader.Read())
                    {
                        pId = reader.GetInt32(0);
                        role = reader.GetByte(1);
                    }
                    reader.Close();

                    LookUp r = LookUpDL.retrieveLookUp((int)role);

                    if(r.Value == "customer")
                    {
                        SqlCommand cmd2 = new SqlCommand("Select CustomerId From Customer Where PersonId = @u", con);
                        cmd2.Parameters.AddWithValue("@u", pId);

                        int cId = int.Parse(cmd2.ExecuteScalar().ToString());
                        cmd2.ExecuteNonQuery();

                        CustomerDL.retrieveCustomer(cId);
                        return "Welcome User"!;
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("Select EmployeeId From Employee Where PersonId = @u", con);
                        cmd2.Parameters.AddWithValue("@u", pId);

                        int cId = int.Parse(cmd2.ExecuteScalar().ToString());
                        cmd2.ExecuteNonQuery();

                        EmployeeDL.retrieveEmployee(cId);
                        return "Login Successful!";
                    }
                }

                else
                {
                    return "Incorrect username or password";
                }
            }
            catch
            {
                return "Error! Please try again.";
            }
        }
    }
}
