using System;

namespace AlgorithmsExcise.Algorithms
{
    public class Stack<T>
    {
        public Stack(int n)
        {
            S = new T[n];
            top = -1;
        }
        T[] S;
        int top;
        public bool Empty
        {
            get
            {
                if (top == -1)
                    return true;
                else return false;
            }
        }
        public bool Full
        {
            get
            {
                if (top == S.Length - 1)
                    return true;
                else return false;
            }
        }
        public void Push(T x)
        {
            if (Full)
                throw new Exception("upflow");
            top = top + 1;
            S[top] = x;
        }
        public T Pop()
        {
            if (Empty)
                throw new Exception("downflow");
            T x = S[top];
            top = top - 1;
            return x;
        }
    }
}
