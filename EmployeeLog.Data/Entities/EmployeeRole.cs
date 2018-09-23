using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Data.Entities
{
    public class EmployeeRole
    {
        public int EmployeeID { get; set; }

        public int RoleID { get; set; }

        public Employee Employee { get; set; }

        public Role Role { get; set; }
    }
}
