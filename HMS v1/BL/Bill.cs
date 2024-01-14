using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Bill
    {
        private int billId;
        private DateTime date;
        private int amount;
        private string status;

        public int BillId { get => billId; set => billId = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Status { get => status; set => status = value; }

        public Bill(int billId, DateTime date, string status)
        {
            BillId = billId;
            Date = date;
            Status = status;
        }

        public Bill(DateTime date, string status)
        {
            Date = date;
            Status = status;
        }
    }
}
