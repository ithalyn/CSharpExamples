using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWinForm {
    public class EmployeeRepository {
        public List<Employee> FetchEmployees(){
            return new List<Employee>{
                new Employee{Name="Alex Ross", Title = "Technical Coordinator", HireDate = new DateTime(2012,02,15)},
                new Employee{Name="Matt Hill", Title = "Technical Coordinator", HireDate = new DateTime(2012,02, 01)},
                new Employee{Name="Gabe Owens", Title = "Web Developer", HireDate = new DateTime(2013, 05, 20, 12,30,05)}
            };
        }
    }
}
