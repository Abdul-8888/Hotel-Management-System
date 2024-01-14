using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;

namespace HMS_v1.DL
{
    public class LookUpDL
    {
        public static bool addLookUp(LookUp data)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertLookUp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = data.Category;
                cmd.Parameters.Add("@value", SqlDbType.Int).Value = data.Value;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateLookUp(LookUp newData)
        {
            LookUp prevData = retrieveLookUp(newData.Id);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevData.Category != newData.Category)
                {
                    SqlCommand cmd = new SqlCommand("Update LookUp Set Category = @name Where Id = @id", con);
                    cmd.Parameters.AddWithValue("@name", newData.Category);
                    cmd.Parameters.AddWithValue("@id", newData.Id);
                    cmd.ExecuteNonQuery();
                }

                if (prevData.Value != newData.Value)
                {
                    SqlCommand cmd = new SqlCommand("Update LookUp Set Value = @name Where Id = @id", con);
                    cmd.Parameters.AddWithValue("@name", newData.Value);
                    cmd.Parameters.AddWithValue("@id", newData.Id);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static LookUp retrieveLookUp(int id)
        {
            string category = "";
            string value = "";

            var conn = Configuration.getInstance().getConnection();
            SqlCommand cmdn = new SqlCommand("Select * From LookUp Where Id = @id", conn);
            cmdn.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmdn.ExecuteReader();
            if (reader.Read())
            {
                category = reader.GetString(1);
                value = reader.GetString(2);
            }
            reader.Close();
            cmdn.ExecuteNonQuery();

            LookUp l = new LookUp(id, category, value);

            return l;
        }

        public static int retrieveLookUp(string category, string value)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id From LookUp Where Category = @cat And Value = @val", con);
            cmd.Parameters.AddWithValue("@cat", category);
            cmd.Parameters.AddWithValue("@val", value);

            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery ();

            return id;
        }

        public static DataTable retrieveLookUp(string category)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Value from Lookup Where Category = @cat", con);
            cmd.Parameters.AddWithValue("@cat", category);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            return dt;
        }

        public static DataTable retrieveLookUp()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From LookUp", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            return dt;
        }
    }
}
