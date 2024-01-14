using HMS_v1.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace HMS_v1.DL
{
    public static class ServiceDL
    {
        public static Service current;

        public static bool addService(Service service)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertService", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = service.Name;
                cmd.Parameters.Add("@cost", SqlDbType.Int).Value = service.Cost;

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

        public static bool addService(Service service, int branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertBranchService", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@serviceId", SqlDbType.Int).Value = service.ServiceId;
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

        public static bool deleteService(int serviceId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "Service";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;
                
                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "ServiceId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = serviceId;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteService(int serviceId, string branchId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_delete2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "BranchService";
                cmd.Parameters.Add("@lookUpValue", SqlDbType.VarChar).Value = "Availability";

                int id = LookUpDL.retrieveLookUp("Availability", "unavailable");
                cmd.Parameters.Add("@lookUpValId", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@objectName", SqlDbType.VarChar).Value = "ServiceId";
                cmd.Parameters.Add("@objectId", SqlDbType.Int).Value = serviceId;

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

        public static bool updateService(Service newService)
        {
            Service prevService = retrieveService(newService.ServiceId);

            try
            {
                var con = Configuration.getInstance().getConnection();

                if (prevService.Name != newService.Name)
                {
                    SqlCommand cmd = new SqlCommand("Update Service Set Name = @name Where ServiceId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newService.Name);
                    cmd.Parameters.AddWithValue("@id", newService.ServiceId);
                    cmd.ExecuteNonQuery();
                }

                if (prevService.Cost != newService.Cost)
                {
                    SqlCommand cmd = new SqlCommand("Update Service Set Cost = @name Where ServiceId = @id", con);
                    cmd.Parameters.AddWithValue("@name", newService.Cost);
                    cmd.Parameters.AddWithValue("@id", newService.ServiceId);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Service retrieveService(int serviceId)
        {
            string name = "";
            int cost = 0;

            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select * From Service Where ServiceId = @id", con);
            cmd.Parameters.AddWithValue("@id", serviceId);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString(1);
                cost = reader.GetInt32(2);
            }

            cmd.ExecuteNonQuery();

            Service f = new Service(serviceId, name, cost);

            return f;
        }

        /*public static Service retrieveservice(int serviceId, int branchId)
        {

        }*/

        public static DataTable retrieveService()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Service", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool availService(Service service, int customerId, int billId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd = new SqlCommand("sp_insertCustomerService", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billId", SqlDbType.VarChar).Value = billId;
                cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("@serviceId", SqlDbType.Int).Value = service.ServiceId;
                cmd.Parameters.Add("@serviceUsage", SqlDbType.Int).Value = 1;

                int total = 1 * service.Cost;

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
