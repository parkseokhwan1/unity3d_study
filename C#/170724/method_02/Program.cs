using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_02
{
    class Program
    {
        // C 언어 : 메서드를 선언(형태를 정의 : 메모리 사용X, 
        //                       메서드가 어떻게 작동되는지 로직만 작성)
        //          이후에 사용가능
        // main 상단부에 메서드가 위치, 메서드 로직 비대화
        // 실제 메인로직의 수정 어려움 -> 메서드 프로토 타입
        // 메서드를 선언부와 비슷하게 {} 없이, 재정의 끝에 ;
        // static void method_B() ;

        // C# 메서드가 정의 되있으면 어디서든 호출 가능하고
        // 메서드 정의 위치는 중요하지 않다.
        // ( 메서드 정의위치 중요X, 메서드 정의가 되있는지가 중요함 )
        // => 메서드의 프로토 타입이 필요 없다

        static void method_A()
        {
            Console.WriteLine("A 메서드");
        }

        // 중첩 메서드 : 호출된 메서드 내에서 다른 메서드를 호출해서 사용할 수 있다.
        static void method_B()
        {
            method_A();     // 다른 메서드 호출
            Console.WriteLine("B 메서드");
            method_A();
            Console.WriteLine("================");
        }

        static void Main(string[] args)
        {
            method_B();
            method_A();
        }
    }
}
