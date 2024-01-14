using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Order
    {
        private int orderId;
        private int employeeId;
        private DateTime orderDate;

        public int OrderId { get => orderId; set => orderId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
    
        public Order(int orderId, int employeeId, DateTime orderDate)
        {
            OrderId = orderId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
        }

        public Order(int employeeId, DateTime orderDate)
        {
            EmployeeId = employeeId;
            OrderDate = orderDate;
        }
    }
}
