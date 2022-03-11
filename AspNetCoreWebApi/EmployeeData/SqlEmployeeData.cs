using AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _mployeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _mployeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.id = Guid.NewGuid();
            _mployeeContext.MyEmployees.Add(employee);
            _mployeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _mployeeContext.MyEmployees.Remove(employee);
            _mployeeContext.SaveChanges();
        }

        public Employee EditeEmployee(Employee employee)
        {
            var exitsEmployee = _mployeeContext.MyEmployees.Find(employee.id);
            if (exitsEmployee != null)
            {
                exitsEmployee.name= employee.name;
                exitsEmployee.salary = employee.salary;
                exitsEmployee.department = employee.department;

                _mployeeContext.MyEmployees.Update(exitsEmployee);
                _mployeeContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _mployeeContext.MyEmployees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
           return  _mployeeContext.MyEmployees.ToList();
        }
    }
}
