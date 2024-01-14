using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class LookUp
    {
        private int id;
        private string category;
        private string value;

        public int Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public string Value { get => value; set => this.value = value; }
    
        public LookUp(int id, string category, string value)
        {
            Id = id;
            Category = category;
            Value = value;
        }

        public LookUp(string category, string value)
        {
            Category = category;
            Value = value;
        }
    }
}
