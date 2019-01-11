using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasGlobal.BusinessLogic;
using MasGlobal.DataAccess.Repositories;
using MasGlobal.DTOs;
using MasGlobal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasGlobalApi.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            EmployeeBL employeeBL = new EmployeeBL();
            IEnumerable<EmployeeDTO> employees = employeeBL.GetEmployees();
            return employees;
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeDTO Get(int id)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            var employee = employeeBL.GetEmployeeById(id);
            return employee;
        }

    
    }
}
