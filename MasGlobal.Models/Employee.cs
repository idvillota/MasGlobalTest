using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MasGlobal.Models
{
    [DataContract]
    public class Employee
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "contractTypeName")]
        public string ContractTypeName { get; set; }

        [DataMember(Name = "roleId")]
        public int RoleId { get; set; }

        [DataMember(Name = "roleName")]
        public string RoleName { get; set; }

        [DataMember(Name = "roleDescription")]
        public string RoleDescription { get; set; }

        [DataMember(Name = "hourlySalary")]
        public double HourlySalary { get; set; }

        [DataMember(Name = "monthlySalary")]
        public double MonthSalary { get; set; }

        [DataMember(Name = "salary")]
        public double Salary { get; set; }
    }
}
