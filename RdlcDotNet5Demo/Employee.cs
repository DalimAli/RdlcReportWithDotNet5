using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RdlcDotNet5Demo
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        public static IEnumerable<Employee> Gets()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = "1001",
                    EmployeeName = "Md. Dalim Ali",
                    Designation = "Software Engineer",
                    Department = "Alico Claim"
                },new Employee()
                {
                    EmployeeId = "1002",
                    EmployeeName = "Md. Sumon Ali",
                    Designation = "Engineer",
                    Department = "Enterprise"
                },new Employee()
                {
                    EmployeeId = "1003",
                    EmployeeName = "Md. Saddam Hossain",
                    Designation = "Software Engineer",
                    Department = "Alico Claim"
                },
                new Employee()
                {
                    EmployeeId = "1004",
                    EmployeeName = "Md. Jafor Ali",
                    Designation = "Engineer",
                    Department = "Enterprise"
                },
                new Employee()
                {
                    EmployeeId = "1005",
                    EmployeeName = "Md. Khaled",
                    Designation = "Software Engineer",
                    Department = "Enterprise"
                },
                new Employee()
                {
                    EmployeeId = "1006",
                    EmployeeName = "Md. Hossain Ali",
                    Designation = "Tech Software Engineer",
                    Department = "Enterprise"
                },
            };
        }
    }
}
