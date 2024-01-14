using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Person
    {
        protected int personId;
        protected string username;
        protected string password;
        protected double cnic;
        protected string firstName;
        protected string lastName;
        protected string middleName;
        protected DateTime dateOfBirth;
        protected string gender;
        protected string email;
        protected double phone;
        protected string role;

        public int PersonId { get => personId; set => personId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public double Cnic { get => cnic; set => cnic = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public double Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }
    
        public Person(int personId, string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role)
        {
            PersonId = personId;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Email = email;
            Phone = phone;
            Role = role;
        }

        public Person(string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role)
        {
            Username = username;
            Password = password;
            Cnic = cnic;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Email = email;
            Phone = phone;
            Role = role;
        }
    }
}
