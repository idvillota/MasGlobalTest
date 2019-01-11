using MasGlobal.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.BusinessLogic.Factory
{
    abstract class EmployeeDTOFactory
    {
        public abstract EmployeeDTO GetEmployeeDTO();
    }
}
