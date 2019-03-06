using System;
//如何检验？
namespace AlgorithmsExcise.Algorithms
{
    public class deque<T> 
    {
        public deque(int n)
        {
            Q = new T[n + 2];
            head = 0;
            tail = 1;
        }
        T[] Q;
        int head;
        int tail;
        public bool Full
        {
            get
            {
                if (head - 1 == tail || (head == 0 && tail == Q.Length - 1))
                    return true;
                else return false;
            }
        }
        public bool Empty
        {
            get
            {
                if (head + 1 == tail || (head == Q.Length - 1 && tail == 0))
                    return true;
                else return false;
            }
        }
        public void ENQUEUE_FRONT(T x)
        {
            if (Full) throw new Exception("upflow");
            Q[head] = x;
            if (head == 0)
            {
                head = Q.Length - 1;
            }
            else head = head - 1;
        }
        public void ENQUEUE_BACK(T x)
        {
            if (Full) throw new Exception("upflow");
            Q[tail] = x;
            if (tail == Q.Length - 1)
            {
                tail = 0;
            }
            else tail = tail + 1;
        }
        public T DEQUEUE_FRONT()
        {
            if (Empty) throw new Exception("downflow");
            if (head==Q.Length-1)
            {
                head = 0;
            }
            else head = head + 1;
            return Q[head];
        }
        public T DEQUEUE_BACK()
        {
            if (Empty) throw new Exception("downflow");
            if (tail==0)
            {
                tail = Q.Length - 1;
            }
            else tail = tail - 1;
            return Q[tail];
        }
    }
}
