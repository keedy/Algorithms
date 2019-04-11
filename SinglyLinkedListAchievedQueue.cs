//加入队列从尾巴，删除从链表头！
//因为书上对链表只给出了从头插入的INSERT方法，限制了我的思路！
//所以一定要明确一个数据结构的本质是什么？是什么性质使其成为这种数据结构！
//理解题目要求用某种数据结构实现的用意，不是只能用书上给出的一组操作，也不是这种数据结构就只能有这组操作的意思！傻呀！
//数据结构和它的实现是两码事！
namespace AlgorithmsExcise.Algorithms
{
    public class SinglyLinkedListAchievedQueue<T>
    {
        public SinglyLinkedListAchievedQueue()
        {
            SLL = new SinglyLinkedList<T>();
        }
        private SinglyLinkedList<T> SLL;
        private SinglyLinkedObject<T> tail;
        public bool Empty
        {
            get
            {
                return SLL.Head == null;
            }
        }
        public void ENQUEUE(T x)
        {
            if(Empty)
            {
                SLL.Insert(x);
                tail = SLL.Head;
            }
            else
            {
                tail.next = new SinglyLinkedObject<T>() { key = x };
                tail = tail.next;
            }
        }
        public T DEQUEUE()
        {
            if (Empty)
                throw new System.Exception("downflow");
            T x = SLL.Head.key;
            SLL.Delete(SLL.Head);
            return x; 
        }
    }
}
