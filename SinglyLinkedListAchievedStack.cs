using System;

namespace AlgorithmsExcise.Algorithms
{
    public class SinglyLinkedListAchievedStack<T>
    {
        public SinglyLinkedListAchievedStack()
        {
            SLL = new SinglyLinkedList<T>();
        }
        private SinglyLinkedList<T> SLL;
        public bool Empty
        {
            get
            {
                return SLL.Head == null;
            }
        }
        public void Push(T x)
        {
            SLL.Insert(x);
        }
        public T Pop()
        {
            if (Empty)
                throw new Exception("downflow");
            T x = SLL.Head.key;
            SLL.Delete(SLL.Head);
            return x;
        }
    }
}
