using System;

//用两个队列实现一个栈
namespace AlgorithmsExcise.Algorithms
{
    public class TwoQueueStack<T>
    {
        public TwoQueueStack(int n)
        {
            queue = new Queue<T>(n);
            TempQueue = new Queue<T>(n - 1);
        }
        Queue<T> TempQueue;
        Queue<T> queue;
        public bool Empty
        {
            get
            {
                if (queue.Empty)
                    return true;
                else return false;
            }
        }
        public bool Full
        {
            get
            {
                if (queue.Full)
                    return true;
                else return false;
            }
        }
        public void Push(T x)
        {
            queue.ENQUEUE(x);
        }
        public T Pop()
        {
            if (queue.Empty)
                throw new Exception("downflow");
            T X = default(T);
            while (!queue.Empty)
            {
                var x = queue.DEQUEUE();
                if (!queue.Empty)
                {
                    TempQueue.ENQUEUE(x);
                }
                else X = x;
            }
            while(!TempQueue.Empty)
            {
                var x = TempQueue.DEQUEUE();
                queue.ENQUEUE(x);
            }
            return X;
        }
    }
}
