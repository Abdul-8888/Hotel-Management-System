using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Employee: Person
    {
        protected int employeeId;
        protected int branchId;
        protected string jobRole;
        protected int salary;
        protected int superviser;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public string JobRole { get => jobRole; set => jobRole = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Superviser { get => superviser; set => superviser = value; }

        public Employee(int personId, int employeeId, string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role, int branchId, string jobRole, int salary, int superviser) : base(personId, username, password, cnic, firstName, lastName, middleName, dateOfBirth, gender, email, phone, role)
        {
            EmployeeId = employeeId;
            BranchId = branchId;
            JobRole = jobRole;
            Salary = salary;
            Superviser = superviser;
        }

        public Employee(string username, string password, double cnic, string firstName, string lastName, string middleName, DateTime dateOfBirth, string gender, string email, double phone, string role, int branchId, string jobRole, int salary, int superviser) : base(username, password, cnic, firstName, lastName, middleName, dateOfBirth, gender, email, phone, role)
        {
            BranchId = branchId;
            JobRole = jobRole;
            Salary = salary;
            Superviser = superviser;
        }
    }
}
