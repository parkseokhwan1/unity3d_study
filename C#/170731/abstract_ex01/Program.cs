using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상 : 기반객체에서 현재 구현되지 않은 프로토타입의 기능을 정의하고
// 파생객체는 프로토타입을 구현함
// 1) 처리 루틴이 없이 정의만을 내린
// 부모객체는 틀을 잡고, 자식객체가 구현함.

// 사용법
//  - 기반클래스
// 클래스 앞에 abstract 키워드를 붙인다.
// 추상화시킬 메서드 앞에 abstract 키워드를 붙인다.
//  - 파생클래스
// override 키워드를 붙여서 메서드를 구현한다.

abstract class calcA
{
    public int a;
    public int b;
    public abstract void answer();      //cf) 다형성 : virtual - override
    public void setdata (int m, int n)
    {
        a = m;
        b = n;
    }
}

class Plused : calcA
{
    public override void answer()
    {
        Console.WriteLine(a + " " + b + " " + (a + b));
    }
}

namespace abstract_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Plused ps = new Plused();
            ps.setdata(123, 486);
            ps.answer();
        }
    }
}
