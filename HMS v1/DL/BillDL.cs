using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_v1.DL
{
    public static class BillDL
    {
        public static Bill current;

        public static bool generateBill(Bill bill)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBill", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = bill.Date;

                int id = LookUpDL.retrieveLookUp("Status", "unpaid");
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateBill(Food food, int quantity, int billId, int customerId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerFood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@foodId", SqlDbType.Int).Value = food.FoodId;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                int total = multiply(quantity, food.Price);
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateBill(Service service, int serviceUsage, int billId, int customerId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerService", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@serviceId", SqlDbType.Int).Value = service.ServiceId;
                cmd.Parameters.Add("@serviceUsage", SqlDbType.Int).Value = serviceUsage;

                int total = multiply(serviceUsage, service.Cost);
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateBill(Product product, int quantity, int billId, int customerId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@productId", SqlDbType.Int).Value = product.ProductId;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                int total = multiply(quantity, product.UnitPrice);
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateBill(Room room, DateTime from, DateTime to, int billId, int customerId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@roomId", SqlDbType.Int).Value = room.RoomId;
                cmd.Parameters.Add("@bookingFrom", SqlDbType.Int).Value = from;
                cmd.Parameters.Add("@bookingTo", SqlDbType.Int).Value = to;

                TimeSpan diff = to - from;
                int hours = (int)diff.TotalHours;

                int total = multiply(hours, room.CostPerHour);
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Bill getBill(int billId)
        {
            Bill b;
            DateTime date = DateTime.Today;
            int amount = 0;
            int status = 0;

            var con = Configuration.getInstance().getConnection();
            
            SqlCommand cmd = new SqlCommand("Select * From Bill Where BillId = @id", con);
            cmd.Parameters.AddWithValue("@id", billId);
            
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                date = reader.GetDateTime(1);
                amount = reader.GetInt32(2);
                status = reader.GetInt32(3);
            }

            SqlCommand cmd1 = new SqlCommand("Select Value From LookUp Where Id = @id1", con);
            cmd1.Parameters.AddWithValue("@id1", status);
            string temp = cmd1.ExecuteScalar().ToString();
            cmd1.ExecuteNonQuery();

            b = new Bill(billId, date, temp);
            b.Amount = amount;

            cmd.ExecuteNonQuery();

            return b;
        }

        public static int getCustomerBill(int customerId)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select BillId From Bill Where CustomerId = @cId And Status = @stat", con);

            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = customerId;

            SqlCommand cmd1 = new SqlCommand("Select Value From LookUp Where Value = @id1", con);
            cmd1.Parameters.AddWithValue("@id1", "unpaid");
            string temp = cmd1.ExecuteScalar().ToString();
            cmd1.ExecuteNonQuery();

            cmd.Parameters.Add("@stat", SqlDbType.Int).Value = temp;

            int billId = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery();

            return billId;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static bool payBill(int billId, int customerId, string method)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@billId", SqlDbType.Int).Value = billId;

                int id = LookUpDL.retrieveLookUp("Method", method);
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = id;

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
