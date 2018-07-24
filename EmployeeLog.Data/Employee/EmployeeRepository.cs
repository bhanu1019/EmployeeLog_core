using EmployeeLog.Data.DataContext;
using EmployeeLog.Data.Entities;
using EmployeeLog.Domain.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 


namespace EmployeeLog.Data.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeLogDataContext db; 
        public EmployeeRepository()
        {
            db = new EmployeeLogDataContext(); 
        }

        public List<Domain.Employee.Employee> GetEmployees()
        {
            try
            {
                var employees = (from emp in db.Employees
                                 select new Domain.Employee.Employee
                                 {
                                     EmployeeID = emp.EmployeeID,
                                     EmailID = emp.EmailID,
                                     FirstName = emp.FirstName,
                                     Image = emp.Image,
                                     LastName = emp.LastName,
                                     Password = emp.Password,
                                     IsActive = emp.IsActive
                                 }).ToList();
                return employees;
            }
            catch(Exception ex)
            {
                throw; 
            }

        }

    }
}
