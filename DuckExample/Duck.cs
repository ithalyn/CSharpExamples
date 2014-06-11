using System;

namespace DuckExample{
    public class Duck{
        public virtual string Name { get; set; }

        public virtual void Quack(){
            Console.WriteLine("{0} Quack!", Name);
        }

        public virtual void Quack(int numberOfTimes){
            for (int i = 0; i < numberOfTimes; i++){
                Quack();
            }
        }
    }
}