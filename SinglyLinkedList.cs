using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsExcise.Algorithms
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedList() { }
        public SinglyLinkedList(IList<T> list)
        {
            if (list == null || list.Count == 0) { return; }
            Head = new SinglyLinkedObject<T>() { key = list.First() };
            var last = Head;
            for (int i = 1; i < list.Count - 1; i++)
            {
                var current = new SinglyLinkedObject<T>() { key = list[i] };
                last.next = current;
                last = current;
            }
        }
        public SinglyLinkedObject<T> Head { get; private set; }

        public SinglyLinkedObject<T> Search(T x)
        {
            var obj = Head;
            while(obj!=null && !obj.key.Equals(x))
            {
                obj = obj.next;
            }
            return obj;
        }
        /// <summary>
        /// 链接到前端
        /// </summary>
        public void Insert(T x)
        {
            SinglyLinkedObject<T> obj = new SinglyLinkedObject<T>() { key = x, next = Head };
            Head = obj;
        }
        /// <summary>
        /// 不能在O(1)时间内完成Delete操作
        /// </summary>
        public void Delete(SinglyLinkedObject<T> x)
        {
            if (x == null) return;

            if(x.Equals(Head))
            {
                Head = Head.next;
                return;
            }
            //从头开始找喽
            var obj = Head;
            while(obj!=null && !obj.next.Equals(x))
            {
                obj = obj.next;
            }
            if(obj!=null)
            {
                obj.next = x.next;
            }
        }
    }
    public class SinglyLinkedObject<T>
    {
        public T key { get; set; }
        public SinglyLinkedObject<T> next { get; set; }
    }
}
