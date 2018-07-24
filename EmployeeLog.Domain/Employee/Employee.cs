using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Domain.Employee
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailID { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }
    }
}
