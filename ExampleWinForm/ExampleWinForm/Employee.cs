using System;

namespace ExampleWinForm{
    public class Employee{
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public string Department {
            get { return "Development"; }
        }
    }
}