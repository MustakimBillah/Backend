using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>() {

            new Employee(){
                Id=Guid.NewGuid(),
                FirstName="Md.",
                MiddleName="Mustakim",
                LastName="Billah"
            },
            new Employee(){
                Id=Guid.NewGuid(),
                FirstName="Md.",
                MiddleName="Amir",
                LastName="Hamzaa"
            }


        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;

        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existing = GetEmployee(employee.Id);
            existing.FirstName = employee.FirstName;
            existing.MiddleName = employee.MiddleName;
            existing.LastName = employee.LastName;
            return existing;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
