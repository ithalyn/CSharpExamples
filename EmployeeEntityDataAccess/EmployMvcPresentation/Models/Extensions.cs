using System.Collections.Generic;
using System.Linq;
using EmployMvcPresentation.EmployeeDataAccessService;

namespace EmployMvcPresentation.Models {

    public static class Extensions {

        public static IEnumerable<EmployMvcPresentation.Models.EmployeeViewModel> ToViewModels(this IEnumerable<EmployeeContract> employees) {
            var transfers = new List<EmployeeViewModel>();
            employees.ToList().ForEach(e => transfers.Add(e.ToViewModel()));

            return transfers;
        }

        public static EmployeeViewModel ToViewModel(this EmployeeContract employee) {
            return new EmployeeViewModel() {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }

        public static EmployeeContract ToDataContract(this EmployeeViewModel employee) {
            return new EmployeeContract() {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                HireDate = employee.HireDate,
                Title = employee.Title
            };
        }

    }
}