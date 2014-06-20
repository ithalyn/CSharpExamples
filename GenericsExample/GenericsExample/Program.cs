using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample {
    class Program {
        private static void Main(string[] args){
            var outputter = new Outputter();
            outputter.Output("hi there!");
            outputter.Output(12345);
        }
    }
}
