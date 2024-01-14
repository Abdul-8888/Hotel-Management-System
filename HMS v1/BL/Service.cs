using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Service
    {
        private int serviceId;
        private string name;
        private int cost;

        public int ServiceId { get => serviceId; set => serviceId = value; }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
    
        public Service(int serviceId, string name, int cost)
        {
            ServiceId = serviceId;
            Name = name;
            Cost = cost;
        }

        public Service(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
