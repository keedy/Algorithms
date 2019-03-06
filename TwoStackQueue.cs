using System;

//用两个栈实现一个队列
namespace AlgorithmsExcise.Algorithms
{
    public class TwoStackQueue<T>
    {
        public TwoStackQueue(int n)
        {
            stack = new Stack<T>(n);
            TempStack = new Stack<T>(n - 1);
        }
        Stack<T> stack;
        Stack<T> TempStack;
        public bool Empty
        {
            get
            {
                if (stack.Empty)
                    return true;
                else return false;
            }
        }
        public bool Full
        {
            get
            {
                if (stack.Full)
                    return true;
                else return false;
            }
        }
        public void ENQUEUE(T x)
        {
            stack.Push(x);
        }
        public T DEQUEUE()
        {
            if (stack.Empty)
                throw new Exception("downflow");
            T X = default(T);
            while(!stack.Empty)
            {
                var x = stack.Pop();
                if (!stack.Empty)
                {
                    TempStack.Push(x);
                }
                else X = x;
            }
            while(!TempStack.Empty)
            {
                var x = TempStack.Pop();
                stack.Push(x);
            }
            return X;
        }
    }
}
