using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // for 문
             // 횟수제한이 있는 반복문에 사용
       
            int i = 3;
            // 객체지향 언어에서 자료형은 필요할때 생성해서 사용
            // 자료형의 적용범위는 선언 이후부터 해당 영역이 끝날때까지
            for ( ; i<=5; )   // 해당, 셋팅부는 필요에 따라 생략 가능
                //초기값, 조건식(반복문 탈출을 위해), 증감식(반복탈출을 위한 값 변경)
            {
                Console.WriteLine("출력");
                i++;
            }
            Console.WriteLine("출력==>" + i);
            
            
            =========================================================================*/

            /* 1번 구구단

            for (int a = 2; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                }
                Console.WriteLine("===================");
            }
            =========================================================================*/



            /* 2번
             * 
             **
             ***
             ****
             ***** 
             ==============================
             //        *
             //       ***
             //      *****
             //     *******
             //    *********
             

             for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            =========================================================================*/

            /*
            for (int a = 1; a <= 5; a++)
            {
                for(int b = 1; b <= 5; b++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            */


            // 반복문탈출
            // continue : 현재 조건을 건너뜀 (현재 상황만 탈출하고 다시 복귀)
            // break : 가장 가까운 반복문 탈출
            for (int k=1; k<3; k++)
             for (int i=1; i<12; i++)  
            {
                if (i == 5) continue;
                // 탈출시 이하구문은 실행 안됨

                
                if (i == 9) break;
                    Console.WriteLine(i);
            }

        }
    }
}




