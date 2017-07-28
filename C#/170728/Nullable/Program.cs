using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class A
{
    public int m_a;
}

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);

            if(b.HasValue == false)
            {
                Console.WriteLine("값을 셋팅해야함");
                b = 123;
            }
            if (b.HasValue == true)
            {
                Console.WriteLine(b.Value); // 내부의 값출력
                Console.WriteLine(b);   // 내부의 값출력
            }

            var asd = 3;
            // 우변의 값을 기준으로 자료형 해석해서 변수생성
            Console.WriteLine(asd.GetType());
            int dd = asd;
            Console.WriteLine(dd);
            var pp = new A();
            pp.m_a = 33;
        }
    }
}
