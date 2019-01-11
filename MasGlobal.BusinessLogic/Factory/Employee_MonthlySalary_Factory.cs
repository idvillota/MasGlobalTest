using MasGlobal.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
namespace MasGlobal.BusinessLogic.Factory
{
    class Employee_MonthlySalary_Factory : EmployeeDTOFactory
    {
        private double _monthlySalary;

        public Employee_MonthlySalary_Factory(double monthlySalary)
        {
            _monthlySalary = monthlySalary;
        }

        public override EmployeeDTO GetEmployeeDTO()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.Salary = CalculateSalary();
            return employeeDTO;
        }

        internal double CalculateSalary()
        {
            return _monthlySalary * 12;
        }
    }
}
