using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_04
{
    class Program       // 형태를 정한것이지 메모리가 만들어진 것은 아님
    {
        static int num_data = 33;       // 변수가 만들어지고, 저장공간은 생성되지만 33은 셋팅이 안됨

        static void var_data()
        {
            int a = 123;        // 지역변수
            int b = 486;
        }

        static void Main(string[] args)
        {
            // 구체화된 것(메모리 정의된 것만)
            // num_data = 773;
            // int aaa;    // 구체화 (메모리 공간 있음)
            // var_data();
            // Console.WriteLine(num_data);
            int[] num1 = new int[5];
            Console.WriteLine(num1.Length);     // 배열의 길이
            // temp(1);
            // temp(1,1);
            temp(1,1,1);
        }

        static void temp(params int[] datastr)
        {
            Console.WriteLine(datastr.Length);
        }

    }
}


/*
    메서드 내에서 만드는 자료형들은 일반적으로 지역 변수라 한다.
    지역변수 : 특정 영역 안에 만들어진 변수, 해당 영역(블럭)을
    벗어나면 변수는 자동으로 파괴된다.

    cf) static : 정적
    메모리 공간의 정적      => 메모리 공간을 만들고 해당 공간을 재사용한다
    static 변수       -> 호출                       -> 호출 2
    .. 공간을 생성       값의 변경                      반환안한 공간을 재사용(O)
        값 셋팅        값이없을때 초기화                  초기화 셋팅은 하지 않음
                      메서드는 저장공간을 반환하나       값의 변경 가능
                      정적 자료형은 저장공간을 반환안함
                      초기화가 된 경우 다시 초기화 X
    결론 : 지역변수처럼 만들어지나 => 내부형태나 사용은 전역변수처럼 사용할 수 있다.

    사용처 : 어디에서 사용을 하는가?
    main 루틴이 존재하는 경우 static 변수를 사용해도 안해도 무방함
    main 루틴이 존재안하는 경우
    // class나 struct 만 있는경우, main() 없는경우들은
    // 전역변수를 만들 수 없다.
    => 프로그램에서 데이터가 끝까지 유지가 안된다. (상황에 따라 다 삭제가됨)
    static 기호를 통한 변수(자료형)을 만들어서 전역변수처럼 사용한다.
    main 루틴외 공간에서 전역 자료형을 만드는 방법
*/