using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericStack.Lib {

    public class Stack<T> : IGenericStack<T> {

        public Stack()
            : this(new T[0]) {
        }

        public Stack(IEnumerable<T> items) {
            Items = new List<T>(items);
        }

        private List<T> Items { get; set; }

        public T Peek() {
            return Items.Last();
        }

        public T Pop() {
            if (!Items.Any())
                throw new InvalidOperationException("Cannot pop from empty stack");
            var val = Items.Last();
            Items.RemoveAt(Items.Count - 1);
            return val;
        }

        public void Push(T item) {
            Items.Add(item);
        }
    }
}