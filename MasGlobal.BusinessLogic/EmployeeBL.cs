using MasGlobal.BusinessLogic.Factory;
using MasGlobal.DataAccess.Repositories;
using MasGlobal.DTOs;
using MasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasGlobal.BusinessLogic
{
    public class EmployeeBL
    {
        public IEnumerable<EmployeeDTO> GetEmployees()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetAll().Result;
            var employeeDTOs = employees.Select(e => GetEmployeeByContractType(e));            
            return employeeDTOs;
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.GetById(id).Result;
            EmployeeDTO employeeDTO = GetEmployeeByContractType(employee);
            return employeeDTO;
        }

        private EmployeeDTO GetEmployeeByContractType(Employee e)
        {
            EmployeeDTOFactory factory = null;
            EmployeeDTO employeeDTO = null;

            switch (e.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    factory = new Employee_HourlySalary_Factory(e.HourlySalary);
                    break;
                case "MonthlySalaryEmployee":
                    factory = new Employee_MonthlySalary_Factory(e.MonthSalary);
                    break;
            }

            if (null == factory)
            {
                return null;
            }

            employeeDTO = factory.GetEmployeeDTO();
            employeeDTO.Id = e.Id;
            employeeDTO.Name = e.Name;
            employeeDTO.RoleDescription = e.RoleDescription;
            employeeDTO.RoleId = e.RoleId;
            employeeDTO.RoleName = e.RoleName;
            employeeDTO.ContractTypeName = e.ContractTypeName;
            
            return employeeDTO;
        }
    }
}
