using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리스트
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i=0; i<list.Count; i++)
                Console.Write("{0} ", list[i]);
            Console.WriteLine();

            // 큐
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
