using System.Collections.Generic;
using System.Linq;

namespace EmployeeEntityDataAccess {

    public static class Extensions {

        public static IEnumerable<EmployeeDataTransfer> ToDataTransfers(this IEnumerable<Employee> employees) {
            var transfers = new List<EmployeeDataTransfer>();
            employees.ToList().ForEach(e => transfers.Add(e.ToDataTransfer()));

            return transfers;
        }

        public static EmployeeDataTransfer ToDataTransfer(this Employee employee) {
            return new EmployeeDataTransfer {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }

        public static Employee ToEntity(this EmployeeDataTransfer employee) {
            return new Employee {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }

        public static void DeepCopy(this Employee me, EmployeeDataTransfer employee){
            me.Name = employee.Name;
            me.Department = employee.Department;
            me.HireDate = employee.HireDate;
            me.Title = employee.Title;
        }
    }
}