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
    public class NotificationDL
    {
        public static bool addNotification(Notification notification)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertNotification", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = notification.Category;
                cmd.Parameters.Add("@from", SqlDbType.Int).Value = notification.From;
                cmd.Parameters.Add("@to", SqlDbType.Int).Value = notification.To;

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("sp_getMaxId", con);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = "NotificationId";
                cmd2.Parameters.Add("@table", SqlDbType.Int).Value = "Notification";

                cmd2.Parameters.Add("@out", SqlDbType.VarChar, 10);
                cmd2.Parameters["@out"].Direction = ParameterDirection.Output;

                int id = int.Parse(Convert.ToString(cmd2.Parameters["@out"].Value));

                cmd2.ExecuteNonQuery();

                if (notification.Description != "")
                {
                    SqlCommand cmd1 = new SqlCommand("Update Notification Set Description = @description Where NotificationId = @id", con);
                    cmd1.Parameters.Add("@description", SqlDbType.VarChar).Value = notification.Description;
                    cmd1.Parameters.Add("@description", SqlDbType.VarChar).Value = id;

                    cmd1.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool addNotificationDetail(int personId, int notificationId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertNotificationDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@notificationId", SqlDbType.Int).Value = notificationId;
                cmd.Parameters.Add("@personId", SqlDbType.Int).Value = personId;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable retrieveNotification(int personId) 
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select Category, From, To, Description From Notification As n Join NotificationDetail as nd On n.NotificationId = nd.NotificationId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmd.ExecuteNonQuery();

            return dt;
        }

    }
}
