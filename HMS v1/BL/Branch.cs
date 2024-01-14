using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Branch
    {
        private int branchId;
        private string name;
        private int asset;
        private string city;
        private string country;

        public int BranchId { get => branchId; set => branchId = value; }
        public string Name { get => name; set => name = value; }
        public int Asset { get => asset; set => asset = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public Branch(int branchId, string name, string city, string country)
        {
            BranchId = branchId;
            Name = name;
            City = city;
            Country = country;
        }

        public Branch(string name, string city, string country)
        {
            Name = name;
            City = city;
            Country = country;
        }
    }
}
