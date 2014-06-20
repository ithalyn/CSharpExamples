using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployMvcPresentation.Models {
    public class EmployeeViewModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }
    }
}