﻿using MasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.DataAccess.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        private const string URL = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        public async Task<Employee> GetById(int Id)
        {
            var employees = this.GetAll().Result;
            return employees.FirstOrDefault(e => e.Id == Id);
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            Uri uri = new Uri(URL);
            ApiClient client = new ApiClient(uri);
            var result = await client.GetAsyncAll<Employee>();

            return result;
        }
    }
}
