namespace GenericStack.Lib {

    public interface IGenericStack<T> {

        T Peek();

        T Pop();

        void Push(T item);
    }
}