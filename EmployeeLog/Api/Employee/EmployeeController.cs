using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeLog.Services.Employee.Command;
using EmployeeLog.Services.Employee.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLog.Api.Employee
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeCommand _employeeCommand;
        private readonly IEmployeeQuery _employeeQuery; 
        public EmployeeController(IEmployeeCommand employeeCommand, IEmployeeQuery employeeQuery)
        {
            _employeeCommand = employeeCommand;
            _employeeQuery = employeeQuery; 
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                var employees = _employeeQuery.GetEmployees();
                return Ok(employees); 
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }
        }
    }
}