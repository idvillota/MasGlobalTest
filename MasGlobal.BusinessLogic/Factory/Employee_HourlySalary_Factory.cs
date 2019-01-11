using MasGlobal.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.BusinessLogic.Factory
{
    class Employee_HourlySalary_Factory : EmployeeDTOFactory
    {
        private double _hourlySalary;

        public Employee_HourlySalary_Factory(double hourlySalary)
        {
            _hourlySalary = hourlySalary;
        }

        public override EmployeeDTO GetEmployeeDTO()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.Salary = CalculateSalary();
            return employeeDTO;
        }

        internal double CalculateSalary()
        {
            return 120 * _hourlySalary * 12;
        }
    }
}
