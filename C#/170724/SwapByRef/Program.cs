﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByRef
{
    class Program
    {
        static void Swap(ref int a, ref int b)          // ref : 주소값을 받는 자료형
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("x:{0}, y:{1}", x, y);

            Swap(ref x, ref y);

            Console.WriteLine("x:{0}, y:{1}", x, y);
        }
    }
}