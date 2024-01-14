using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_v1.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HMS_v1.DL
{
    public static class ProductDL
    {
        public static bool addProduct(Product product)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@unitPrice", SqlDbType.Int).Value = product.UnitPrice;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = product.Name;

                int id = LookUpDL.retrieveLookUp("Product Type", product.Type);
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

        public static bool addProduct(Product product, int branchId, int quantity, int threshold)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBranchProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@serviceId", SqlDbType.Int).Value = product.ProductId;
                cmd.Parameters.Add("@branchId", SqlDbType.Int).Value = branchId;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@threshold", SqlDbType.Int).Value = threshold;


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

        public static bool removeProduct(int productId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Product";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "ProductId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = productId;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool removeProduct(int productId, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "BranchProduct";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "ProductId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = productId;

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

        public static bool updateProduct(Product newProduct)
        {
            Product prevProduct = retrieveProduct(newProduct.ProductId);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevProduct.Name != newProduct.Name)
                {
                    SqlCommand cmd = new SqlCommand("Update Product Set Name = @name Where ProductId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newProduct.Name);
                    cmd.Parameters.AddWithValue("@id", newProduct.ProductId);
                    cmd.ExecuteNonQuery();
                }

                if (prevProduct.UnitPrice != newProduct.UnitPrice)
                {
                    SqlCommand cmd = new SqlCommand("Update Product Set UnitPrice = @name Where ProductId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newProduct.UnitPrice);
                    cmd.Parameters.AddWithValue("@id", newProduct.ProductId);
                    cmd.ExecuteNonQuery();
                }

                if (prevProduct.Type != newProduct.Type)
                {
                    SqlCommand cmd = new SqlCommand("Update Product Set Type = @name Where ProductId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newProduct.Type);
                    cmd.Parameters.AddWithValue("@id", newProduct.ProductId);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Product retrieveProduct(int productId)
        {
            string name = "";
            int price = 0;
            int type = 0;

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select * From Product Where ProductId = @id", con);
            cmd.Parameters.AddWithValue("@id", productId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString(1);
                price = reader.GetInt32(2);
                type = reader.GetInt32(3);
            }

            cmd.ExecuteNonQuery();

            LookUp t = LookUpDL.retrieveLookUp(type);

            Product f = new Product(productId, name, price, t.Value);

            return f;
        }

        public static DataTable retrieveProduct()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Product", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool createOrder(Product product, int quantity, int employeeId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@employeeId", SqlDbType.Int).Value = employeeId;
                cmd.Parameters.Add("@orderDate", SqlDbType.Int).Value = DateTime.Today;

                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = new SqlCommand("sp_getMaxId", con);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@id", SqlDbType.Int).Value = "OrderId";
                cmd1.Parameters.Add("@table", SqlDbType.Int).Value = "Order";

                cmd1.Parameters.Add("@out", SqlDbType.VarChar, 10);
                cmd1.Parameters["@out"].Direction = ParameterDirection.Output;

                int id = int.Parse(Convert.ToString(cmd1.Parameters["@out"].Value));

                cmd1.ExecuteNonQuery();


                SqlCommand cmd2 = new SqlCommand("sp_insertOrderDetail", con);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@orderId", SqlDbType.Int).Value = id;
                cmd2.Parameters.Add("@productId", SqlDbType.Int).Value = product.ProductId;
                cmd2.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                cmd2.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool createOrder(Product product, int customerId, int billId, int quantity)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerFood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.VarChar).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@foodId", SqlDbType.Int).Value = product.ProductId;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                int total = product.UnitPrice * quantity;
                cmd.Parameters.Add("@totalPrice", SqlDbType.Int).Value = total;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool OrderProduct(Product product, int quantity, int employeeId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("Select Count(OrderId) From Order Where EmployeeId = @eId And OrderDate = @date");
                cmd.Parameters.Add("@eId", SqlDbType.VarChar).Value = employeeId;
                cmd.Parameters.Add("@date", SqlDbType.Int).Value = DateTime.Today;

                int isExist = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.ExecuteNonQuery();

                if (isExist != 0)
                {
                    int orderId = 0;

                    SqlCommand cmd1 = new SqlCommand("Select OrderId From Order Where EmployeeId = @eId And OrderDate = @date");
                    cmd1.Parameters.Add("@eId", SqlDbType.VarChar).Value = employeeId;
                    cmd1.Parameters.Add("@date", SqlDbType.Int).Value = DateTime.Today;

                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        orderId = reader.GetInt32(0);
                    }
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("sp_insertOrderDetail", con);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
                    cmd2.Parameters.Add("@productId", SqlDbType.Int).Value = product.ProductId;
                    cmd2.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                    cmd2.ExecuteNonQuery();
                }

                else
                {
                    createOrder(product, quantity, employeeId);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
