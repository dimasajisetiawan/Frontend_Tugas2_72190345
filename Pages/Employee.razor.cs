using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync(){
            LoadEmployees();
            return base.OnInitializedAsync();
        } 

        

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Dimas",
                LastName="Setiawan",
                Email="dimazaji619@gmail.com",
                DateOfBirth = new DateTime(2000,11,16),
                gender = Employee.Gender.Male,
                Department = new Department{DepartmentId=1, DepartmentName="IT"},
                PhotoPath = "images/dimas.jpg"
            };
            Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Prima",
                LastName="Pamungkas",
                Email="prima666@gmail.com",
                DateOfBirth = new DateTime(2000,07,06),
                gender = Employee.Gender.Male,
                Department = new Department{DepartmentId=2, DepartmentName="HR"},
                PhotoPath = "images/prima.jpg"
            };
            Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Bara",
                LastName="Adiguna",
                Email="bara666@gmail.com",
                DateOfBirth = new DateTime(2000,05,05),
                gender = Employee.Gender.Male,
                Department = new Department{DepartmentId=3, DepartmentName="IT"},
                PhotoPath = "images/bara.jpg"
            };
            Employee e4 = new Employee{
                EmployeeId=4,
                FirstName="Cloud",
                LastName="Strlife",
                Email="cloud999@gmail.com",
                DateOfBirth = new DateTime(2000,05,11),
                gender = Employee.Gender.Male,
                Department = new Department{DepartmentId=4, DepartmentName="IT"},
                PhotoPath = "images/cloud.jpg"
            };

            Employees = new List<Employee>{e1,e2,e3};
        }
    }
}