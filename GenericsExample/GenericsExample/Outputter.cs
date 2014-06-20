using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample {
    class Outputter {

        public void Output<T>(T thing) where T : IConvertible, IComparable<T> {
            Console.WriteLine(thing);
            
        }

    }

    internal interface IDuck{}
}
