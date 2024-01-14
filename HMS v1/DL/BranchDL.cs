using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;

namespace HMS_v1.DL
{
    public static class BranchDL
    {
        public static Branch current;
        public static bool insertBranch(Branch branch)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBranch", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = branch.Name;
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = branch.City;
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = branch.Country;

                int id = LookUpDL.retrieveLookUp("inUse", "true");
                cmd.Parameters.Add("@inUse", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                current = branch;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteBranch(int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Branch";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "inUse";

                int id = LookUpDL.retrieveLookUp("inUse", "false");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "BranchId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = branchId;

                cmd.ExecuteNonQuery();


                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateBranch(Branch newBranch)
        {
            Branch prevBranch = retrieveBranch(newBranch.BranchId);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevBranch.Name != newBranch.Name)
                {
                    SqlCommand cmd = new SqlCommand("Update Branch Set Name = @name Where BranchId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newBranch.Name);
                    cmd.Parameters.AddWithValue("@id", newBranch.BranchId);
                    cmd.ExecuteNonQuery();
                }

                if (prevBranch.City != newBranch.City)
                {
                    SqlCommand cmd = new SqlCommand("Update Branch Set City = @name Where BranchId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newBranch.City);
                    cmd.Parameters.AddWithValue("@id", newBranch.BranchId);
                    cmd.ExecuteNonQuery();
                }

                if (prevBranch.Country != newBranch.Country)
                {
                    SqlCommand cmd = new SqlCommand("Update Branch Set Country = @name Where BranchId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newBranch.Country);
                    cmd.Parameters.AddWithValue("@id", newBranch.BranchId);
                    cmd.ExecuteNonQuery();
                }

                current = newBranch;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Branch retrieveBranch(int branchId)
        {
            string name = "";
            string city = "";
            string country = "";

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Branch Where BranchId = @id", con);
            cmd.Parameters.AddWithValue("@id", branchId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString(1);
                city = reader.GetString(2);
                country = reader.GetString(3);
            }

            cmd.ExecuteNonQuery();

            Branch b = new Branch(branchId, name, city, country);

            return b;
        }

        public static Branch retrieveBranch(string branch)
        {
            int id = 0;
            string city = "";
            string country = "";

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Branch Where Name = @id", con);
            cmd.Parameters.AddWithValue("@id", branch);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                city = reader.GetString(2);
                country = reader.GetString(3);
            }

            cmd.ExecuteNonQuery();

            Branch b = new Branch(id, branch, city, country);

            return b;
        }


        public static DataTable retrieveBranch()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Branch", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool addAsset(int asset, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("Select Asset From Branch Where BranchId = @id", con);
                cmd.Parameters.AddWithValue("@id", branchId);
                int add = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.ExecuteNonQuery();

                asset += add;

                SqlCommand cmd1 = new SqlCommand("Update Branch Set Asset = @asset Where BranchId = @id", con);
                cmd1.Parameters.AddWithValue("@asset", asset);
                cmd1.Parameters.AddWithValue("@id", branchId);
                cmd1.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool subtractAsset(int asset, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("Select Asset From Branch Where BranchId = @id", con);
                cmd.Parameters.AddWithValue("@id", branchId);
                int sub = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.ExecuteNonQuery();

                asset -= sub;

                SqlCommand cmd1 = new SqlCommand("Update Branch Set Asset = @asset Where BranchId = @id", con);
                cmd1.Parameters.AddWithValue("@asset", asset);
                cmd1.Parameters.AddWithValue("@id", branchId);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}

