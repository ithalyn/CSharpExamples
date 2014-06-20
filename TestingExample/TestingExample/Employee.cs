using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExample {
    public class Employee {
        public void EatPizza(){
            IsFull = true;
        }

        public void EatPizza(SliceOfPizza slice) {
            EatPizza();
            Calories += slice.CalculateCalories();
        }

        public int Calories { get; set; }

        public bool IsFull { get; set; }
    }
}
