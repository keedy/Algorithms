//想象成head到tail顺时针的一个圈

using System;

namespace AlgorithmsExcise.Algorithms
{
    public class Queue<T>
    {
        public Queue(int n)
        {
            Q = new T[n + 1];
            head = 0;
            tail = 0;
        }
        T[] Q;
        int head;
        int tail;
        public bool Empty
        {
            get
            {
                if (head == tail)
                    return true;
                else return false;
            }
        }
        public bool Full
        {
            get
            {
                if (tail + 1 == head || (head == 0 && tail == Q.Length - 1))
                    return true;
                else return false;
            }
        }
        public void ENQUEUE(T x)
        {
            if (Full)
                throw new Exception("upflow");
            Q[tail] = x;
            if (tail == Q.Length - 1)
            {
                tail = 0;
            }
            else tail = tail + 1;
        }
        public T DEQUEUE()
        {
            if (Empty)
                throw new Exception("downflow");
            T x = Q[head];
            if (head == Q.Length - 1)
            {
                head = 0;
            }
            else head = head + 1;
            return x;
        }
    }
}
