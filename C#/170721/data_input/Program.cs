using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string inputnum = Console.ReadLine();
            Console.WriteLine("입력값은 " + inputnum);
            // 숫자로 출력하기
            Console.WriteLine("입력값은 " + int.Parse(inputnum));
            Console.WriteLine("입력값은 " + Convert.ToInt32(inputnum));
            */

            // 요일을 입력받을시 해당 요일을 영어로 출력하는 프로그램 만들기
            // (단, 요일 이외에 글자나 숫자를 입력받으면 "잘못 입력했습니다" 출력
            // Console, Inputline,  1) if-else  2) switch-case 

            string inputday = Console.ReadLine();
            
            switch (inputday)
            {
                case "월":
                    Console.WriteLine("mon");
                    break;
                case "화":
                    Console.WriteLine("tue");
                    break;
                case "수":
                    Console.WriteLine("wed");
                    break;
                case "목":
                    Console.WriteLine("thu");
                    break;
                case "금":
                    Console.WriteLine("fri");
                    break;
                case "토":
                    Console.WriteLine("sat");
                    break;
                case "일":
                    Console.WriteLine("sun");
                    break;
                default:
                    Console.WriteLine("wrong");
                    break;
            }

        }
    }
}
