using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Customer: Person
    {
        private int customerId;

        public int CustomerId { get => customerId; set => customerId = value; }

        public Customer(int personId, int customerId, string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role) : base(personId, username, password, cnic, firstName, lastName, middleName, dateOfBirth, gender, email, phone, role)
        {
            CustomerId = customerId;
        }

        public Customer(string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role) : base(username, password, cnic, firstName, lastName, middleName, dateOfBirth, gender, email, phone, role)
        {
        }
    }
}
