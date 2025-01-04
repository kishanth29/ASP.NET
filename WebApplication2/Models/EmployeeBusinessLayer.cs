using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Kishanth",
                Gender = "Male",
                City = "Jaffna",
                Salary = 1000,
                Address = "Andheri"

            };
            return employee;
        }
    }
}