using HMS_v1.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.DL
{
    public class EmployeeDL
    {
        public static Employee current;

        public static bool addEmployee(Employee employee)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@personId", SqlDbType.Int).Value = employee.PersonId;
                cmd.Parameters.Add("@branchId", SqlDbType.Int).Value = employee.BranchId;

                int id = LookUpDL.retrieveLookUp("JobRole", employee.JobRole);
                cmd.Parameters.Add("@jobRole", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@salary", SqlDbType.Int).Value = employee.Salary;
                cmd.Parameters.Add("@personId", SqlDbType.Int).Value = employee.Superviser;

                id = LookUpDL.retrieveLookUp("Account", "active");
                cmd.Parameters.Add("@account", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool removeEmployee(int employeeId)
        {
            //try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Employee";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Account";

                int id = LookUpDL.retrieveLookUp("Account", "deactive");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "EmployeeId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = employeeId;

                cmd.ExecuteNonQuery();

                return true;
            }
            //catch
            {
                return false;
            }
        }

        public static bool updateEmployee(Employee newEmployee)
        {
            Employee prevEmployee = current;

            //try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevEmployee.Username != newEmployee.Username)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Username = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Username);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Password != newEmployee.Password)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Password = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Password);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Cnic != newEmployee.Cnic)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Cnic = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Cnic);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.FirstName != newEmployee.FirstName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set FirstName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.FirstName);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.LastName != newEmployee.LastName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set LastName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.LastName);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.MiddleName != newEmployee.MiddleName)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set MiddleName = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.MiddleName);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.DateOfBirth != newEmployee.DateOfBirth)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set DateOfBirth = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.DateOfBirth);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Gender != newEmployee.Gender)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Gender = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Gender);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Email != newEmployee.Email)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Email = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Email);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Phone != newEmployee.Phone)
                {
                    SqlCommand cmd = new SqlCommand("Update Person Set Phone = @name Where PersonId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Phone);
                    cmd.Parameters.AddWithValue("@id", newEmployee.PersonId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.BranchId != newEmployee.BranchId)
                {
                    SqlCommand cmd = new SqlCommand("Update Employee Set BranchId = @name Where EmployeeId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.BranchId);
                    cmd.Parameters.AddWithValue("@id", newEmployee.EmployeeId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.JobRole != newEmployee.JobRole)
                {
                    SqlCommand cmd = new SqlCommand("Update Employee Set JobRole = @name Where EmployeeId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.JobRole);
                    cmd.Parameters.AddWithValue("@id", newEmployee.EmployeeId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Salary != newEmployee.Salary)
                {
                    SqlCommand cmd = new SqlCommand("Update Employee Set Salary = @name Where EmployeeId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Salary);
                    cmd.Parameters.AddWithValue("@id", newEmployee.EmployeeId);
                    cmd.ExecuteNonQuery();
                }

                if (prevEmployee.Superviser != newEmployee.Superviser)
                {
                    SqlCommand cmd = new SqlCommand("Update Employee Set Superviser = @name Where EmployeeId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newEmployee.Superviser);
                    cmd.Parameters.AddWithValue("@id", newEmployee.EmployeeId);
                    cmd.ExecuteNonQuery();
                }

                current = retrieveEmployee(newEmployee.EmployeeId);

                return true;
            }
            //catch
            {
                return false;
            }
        }

        public static Employee retrieveEmployee(int employeeId)
        {
            string username = "";
            string password = "";
            string cnic ="";
            string firstName = "";
            string lastName = "";
            string middleName = "";
            DateTime dateOfBirth = DateTime.Today;
            byte gender = 0;
            string email = "";
            string phone = "";
            byte role = 0;
            int branchId = 0;
            byte jobRole = 0;
            int salary = 0;
            int superviser = 0;

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd1 = new SqlCommand("Select PersonId From Employee Where EmployeeId = @id", con);
            cmd1.Parameters.AddWithValue("@id", employeeId);

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

            SqlCommand cmd2 = new SqlCommand("Select * From Employee Where EmployeeId = @id", con);
            cmd2.Parameters.AddWithValue("@id", employeeId);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                branchId = reader2.GetInt32(1);
                jobRole = reader2.GetByte(2);
                salary = reader2.GetInt32(3);
                superviser = reader2.GetInt32(4);
            }

            cmd2.ExecuteNonQuery();

            LookUp gen = LookUpDL.retrieveLookUp((int)gender);
            LookUp ro = LookUpDL.retrieveLookUp((int)role);
            LookUp job = LookUpDL.retrieveLookUp((int)jobRole);

            Employee c = new Employee(personId, employeeId, username, password, double.Parse(cnic), firstName, lastName, middleName, dateOfBirth, gen.Value, email, double.Parse(phone), ro.Value, branchId, job.Value, salary, superviser);
            current = c;
            return c;
        }

        public static DataTable retrieveEmployee()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Person As p Join Employee As e On p.PersonId = e.PersonId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            return dt;
        }

        public static string getEmployeeRole()
        {
            return current.JobRole;
        }
    }
}
