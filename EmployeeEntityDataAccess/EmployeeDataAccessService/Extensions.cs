using System.Collections.Generic;
using System.Linq;
using EmployeeDataAccessService.DataContracts;
using EmployeeEntityDataAccess;

namespace EmployeeDataAccessService {

    public static class Extensions {

        public static IEnumerable<EmployeeContract> ToContracts(this IEnumerable<EmployeeDataTransfer> employees) {
            var transfers = new List<EmployeeContract>();
            employees.ToList().ForEach(e => transfers.Add(e.ToContract()));

            return transfers;
        }

        public static EmployeeContract ToContract(this EmployeeDataTransfer employee) {
            return new EmployeeContract {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }

        public static EmployeeDataTransfer ToEntity(this EmployeeContract employee) {
            return new EmployeeDataTransfer {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }
    }
}