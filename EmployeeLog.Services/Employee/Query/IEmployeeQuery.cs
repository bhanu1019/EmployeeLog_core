using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Services.Employee.Query
{
    public interface IEmployeeQuery
    {
        List<Domain.Employee.Employee> GetEmployees();
    }
}
