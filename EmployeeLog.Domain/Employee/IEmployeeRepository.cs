using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Domain.Employee
{
    public interface IEmployeeRepository
    {
        List<Domain.Employee.Employee> GetEmployees();
    }
}
