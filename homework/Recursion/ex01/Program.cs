using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static int power(int a, int num)
        {
            if (num == 0)
                return 1;

            return a * power(a, num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("거듭제곱 결과 : {0}", power(5, 3));
        }
    }
}
