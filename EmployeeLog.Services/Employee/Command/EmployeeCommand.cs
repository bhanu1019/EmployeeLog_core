using EmployeeLog.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Services.Employee.Command
{
    public class EmployeeCommand : IEmployeeCommand
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeCommand(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository; 
        }
    }
}
