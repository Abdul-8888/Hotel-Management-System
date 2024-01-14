using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Reflection.Metadata;
using System.Data.Common;

namespace HMS_v1.DL
{
    public static class ReviewDL
    {
        public static bool addReview(Review review)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insertReview", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = review.CustomerId;
                cmd.Parameters.Add("@comment", SqlDbType.VarChar).Value = review.Comment;
                cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = review.Date;
                cmd.Parameters.Add("@rating", SqlDbType.Int).Value = review.Rating;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable retrieveReview(int customerId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Review Where CustomerId = @c", con);
            cmd.Parameters.AddWithValue("@rating", customerId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
