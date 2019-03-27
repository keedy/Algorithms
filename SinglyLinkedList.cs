using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExcise.Algorithms
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedList() { }
        public SinglyLinkedList(IList<T> list)
        {
            if (list == null || list.Count == 0) { return; }
            Head = new SinglyLinkedObject() { key = list.First() };
            var last = Head;
            for (int i = 1; i < list.Count - 1; i++)
            {
                var current = new SinglyLinkedObject() { key = list[i] };
                last.next = current;
                last = current;
            }
        }
        public SinglyLinkedObject Head { get; private set; }

        public SinglyLinkedObject Search(T x)
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
            SinglyLinkedObject obj = new SinglyLinkedObject() { key = x, next = Head };
            Head = obj;
        }
        /// <summary>
        /// 不能在O(1)时间内完成Delete操作
        /// </summary>
        public void Delete(SinglyLinkedObject x)
        {
            if (x == null) return;

            if(x.Equals(Head))
            {
                Head = Head.next;
                return;
            }

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
        public class SinglyLinkedObject
        {
            public T key { get; set; }
            public SinglyLinkedObject next { get; set; }
        }
    }
}
