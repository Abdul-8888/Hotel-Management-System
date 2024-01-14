using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HMS_v1.DL
{
    public static class FoodDL
    {
        public static Food current;

        public static bool addFood(Food food)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertFood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = food.DishName;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = food.Price;

                int id = LookUpDL.retrieveLookUp("Availability", "available");
                cmd.Parameters.Add("@availability", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool addFood(Food food, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBranchFood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@serviceId", SqlDbType.Int).Value = food.FoodId;
                cmd.Parameters.Add("@branchId", SqlDbType.Int).Value = branchId;

                int id = LookUpDL.retrieveLookUp("Availability", "available");
                cmd.Parameters.Add("@availability", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteFood(int foodId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Food";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "FoodId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = foodId;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteFood(int foodId, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "BranchFood";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "FoodId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = foodId;

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

        public static bool updateFood(Food newFood)
        {
            Food prevFood = retrieveFood(newFood.FoodId);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevFood.DishName != newFood.DishName)
                {
                    SqlCommand cmd = new SqlCommand("Update Food Set DishName = @name Where FoodId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newFood.DishName);
                    cmd.Parameters.AddWithValue("@id", newFood.FoodId);
                    cmd.ExecuteNonQuery();
                }

                if (prevFood.Price != newFood.Price)
                {
                    SqlCommand cmd = new SqlCommand("Update Food Set Price = @name Where FoodId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newFood.Price);
                    cmd.Parameters.AddWithValue("@id", newFood.FoodId);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Food retrieveFood(int foodId)
        {
            string dishName = "";
            int price = 0;

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select * From Food Where FoodId = @id", con);
            cmd.Parameters.AddWithValue("@id", foodId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dishName = reader.GetString(1);
                price = reader.GetInt32(2);
            }

            cmd.ExecuteNonQuery();

            Food f = new Food(dishName, price);

            return f;
        }

        public static DataTable retrieveFood()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool orderFood(int quantity, int customerId, int billId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerFood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.VarChar).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@foodId", SqlDbType.Int).Value = current.FoodId;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                int total = current.Price * quantity;
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

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
