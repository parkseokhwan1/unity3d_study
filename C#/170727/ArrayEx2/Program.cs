using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arrdata = { 5,3 , 4, 2, 2 };
            System.Array.Sort(arrdata);
            for(i=0;i<arrdata.Length;i++)
            Console.Write("  " + arrdata[i]);
            Console.WriteLine("\n -------------------");
            System.Array.Clear(arrdata, 0, arrdata.Length);
            //                 배열자료형 시작위치 끝위치    =>세팅된 영역을 클리어.
            for (i = 0; i < arrdata.Length; i++)
                Console.Write("  " + arrdata[i]);

            int[] tst = { 1, 3, 5, 7, 9 };
            int indexnum = System.Array.IndexOf(tst, 7);
            Console.WriteLine("\n 7이 있는 값은 배열의 {0} 번쨰 인덱스입니다", indexnum);
            
        }
    }
}
