using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasGlobal.DTOs;
using MasGlobal.Web.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasGlobal.Web.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private const string URL = "http://localhost:55077/api/employees";
        public IEnumerable<EmployeeDTO> employees;

        [BindProperty(SupportsGet = true)]
        public int EmployeeId { get; set; }

        public void OnGet()
        {
            employees = GetEmployees();
        }

        public IEnumerable<EmployeeDTO> GetEmployees()
        {
            Uri uri = new Uri(URL);
            ApiClient client = new ApiClient(uri);

            var employees = client.GetAsyncAll<EmployeeDTO>().Result;

            if (EmployeeId != 0)
            {
                EmployeeDTO employeeDTO = employees.FirstOrDefault(e => e.Id == EmployeeId);
                employees = new List<EmployeeDTO>();
                if (null != employeeDTO)
                {
                    employees.Add(employeeDTO);
                }

            }

            return employees;
        }
    }
}