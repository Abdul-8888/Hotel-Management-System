using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HMS_v1.DL
{
    public static class RoomDL
    {
        public static Room current;

        public static bool addRoom(Room room)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@roomNo", SqlDbType.VarChar).Value = room.RoomNo;
                cmd.Parameters.Add("@costPerHour", SqlDbType.Int).Value = room.CostPerHour;

                int id = LookUpDL.retrieveLookUp("Room Type", room.Type);
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = id;

                id = LookUpDL.retrieveLookUp("Availability", "available");
                cmd.Parameters.Add("@availability", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool addRoom(Room room, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBranchRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@roomId", SqlDbType.VarChar).Value = room.RoomId;
                cmd.Parameters.Add("@branchId", SqlDbType.Int).Value = branchId;

                int id = LookUpDL.retrieveLookUp("Availability", "available");
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool removeRoom(int roomId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                /*SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Room";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpid", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "RoomId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = roomId;*/

                SqlCommand cmd = new SqlCommand("Update Room Set Availability = @id Where RoomId = @room", con);
                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@room", roomId);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool removeRoom(int roomId, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "BranchRoom";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "RoomId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = roomId;

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

        public static bool updateRoom(Room newRoom)
        {
            Room prevRoom = retrieveRoom(newRoom.RoomId);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevRoom.RoomNo != newRoom.RoomNo)
                {
                    SqlCommand cmd = new SqlCommand("Update Room Set RoomNo = @name Where RoomId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newRoom.RoomNo);
                    cmd.Parameters.AddWithValue("@id", newRoom.RoomId);
                    cmd.ExecuteNonQuery();
                }

                if (prevRoom.CostPerHour != newRoom.CostPerHour)
                {
                    SqlCommand cmd = new SqlCommand("Update Room Set CostPerHour = @name Where RoomId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newRoom.CostPerHour);
                    cmd.Parameters.AddWithValue("@id", newRoom.RoomId);
                    cmd.ExecuteNonQuery();
                }

                if (prevRoom.Type != newRoom.Type)
                {
                    SqlCommand cmd = new SqlCommand("Update Room Set Type = @name Where RoomId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newRoom.Type);
                    cmd.Parameters.AddWithValue("@id", newRoom.RoomId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("UPDATE rOOM");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Room retrieveRoom(int roomId)
        {
            int roomNo = 0;
            int costPerHour = 0;
            int type = 0;
            int availability = 0;
            
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select * From Room Where RoomId = @id", con);
            cmd.Parameters.AddWithValue("@id", roomId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                roomNo = reader.GetInt32(1);
                costPerHour = reader.GetInt32(2);
                type = reader.GetByte(3);
            }
            reader.Close();
            cmd.ExecuteNonQuery();

            LookUp t = LookUpDL.retrieveLookUp(type);
            LookUp a = LookUpDL.retrieveLookUp(availability);

            Room r = new Room(roomId, roomNo, costPerHour, a.Value, t.Value);
            MessageBox.Show("RETRIEVE rOOM");
            return r;
        }

        public static DataTable retrieveRoom()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Room", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool bookRoom(int roomId, DateTime bookFrom, DateTime bookTo, int billId, int customerId)
        {
            //try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@roomId", SqlDbType.Int).Value = roomId;
                cmd.Parameters.Add("@bookingFrom", SqlDbType.DateTime).Value = bookFrom;
                cmd.Parameters.Add("@bookingTo", SqlDbType.DateTime).Value = bookTo;

                cmd.ExecuteNonQuery();

                return true;
            }
            //catch
            {
                return false;
            }
        }

        public static bool useRoom(int roomId, DateTime checkIn, string check)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("Update CustomerRooom Set @check = @checkIn Where RoomId = @roomId", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = checkIn;
                cmd.Parameters.Add("@check", SqlDbType.DateTime).Value = check;
                cmd.Parameters.Add("@roomId", SqlDbType.Int).Value = roomId;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
