using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float[] fnum = new float[3];            // 빈배열
            fnum[0] = 0.1f;
            fnum[1] = 0.01f;
            fnum[2] = 0.001f;
            for (int i = 0; i < 3; i++)
                Console.WriteLine("float 배열 1 => " + fnum[i]);

            float[] fnum2 = /* (new float[]) */ { 0.9f, 0.8f, 0.7f, 0.6f, 0.5f };       // 생성과 동시에 초기화
            Console.WriteLine("float 배열 2 => " + fnum2[4]);
        }
    }
}



/*
           // 배열 array 
           // 같은 형태의 여러개의 자료형을 하나의 이름으로 정의해서 사용
           // int[] a = new int[5];       //int a[5];
           // 1. 배열형변수 선언 2. 개수나 값의 초기화
           int[] num;  // 데이터형 [] 배열명
           num = new int[5];   // 초기화 : new 데이터형[개수]; => 배열변수에 할당 , new 선언 변수는 초기에 내부메모리에 0 셋팅
           // 값의 셋팅
           num[0] = 111;
           num[1] = 222;
           num[2] = 333;
           num[3] = 444;
           num[4] = 555;
           for (int i = 0; i < 5; i++)
               Console.WriteLine("int 배열 1 => " + num[i]);

           //int a[5] => int []as = new int[5]
           //int a[5] = { };   int []a = new int[5]
           //int[] num2 = new int[5] {   };
           //int a[] = { 1, 2, 3, 4, 5 }; => int[] num2 = {111,222,333}
           int[] num2 = { 486, 123, 999, 777, 888 };
               Console.WriteLine("int 배열 2 => " + num2[3]);

   */
