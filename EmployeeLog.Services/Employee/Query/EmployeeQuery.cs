using EmployeeLog.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Services.Employee.Query
{
    public class EmployeeQuery : IEmployeeQuery
    {
        private readonly IEmployeeRepository _employeeRepository; 
        public EmployeeQuery(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository; 
        }

        public List<Domain.Employee.Employee> GetEmployees()
        {
            try
            {
                return _employeeRepository.GetEmployees();
            }
            catch(Exception ex)
            {
                throw; 
            }
        }
    }
}
