using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using DuckExample;

namespace DuckExample {
    class Program {
        private static void Main(string[] args){
            Duck myDuck = new Mallard{Name = "Alex"};
            myDuck.Quack(2);
        }
    }
}
