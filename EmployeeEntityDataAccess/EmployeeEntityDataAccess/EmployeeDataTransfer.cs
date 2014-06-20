using System;

namespace EmployeeEntityDataAccess{
    public class EmployeeDataTransfer{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }
    }
}