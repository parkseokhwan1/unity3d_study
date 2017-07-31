using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 인터페이스의 상속
 * 인터페이스는 클래스처럼 상속해서 새로운 인터페이스를 만들 수 있다.
 * 이때 상속받는 클래스는 ':' 기호를 사용한다.
 * ex) Interface A:B
 * {}
 * 인터페이스는 복수로 상속받아서 쓸 수 있다 -> 기능(메서드)의 형태만 추가하기 때문에
 * ex) Interface A: B,c,d,e;
 * {
 * }
 */

interface A
{
    void f();
}

interface B : A
{
    new void f();
}

// 상속대상 인터페이스에 같은 메서드가 있을때 -> new 키워드를 통해 
// 상속대상 메서드를 우선순위에 놓고 기반 메서드를 은폐시킨다

/* 상속형식을 만들때, 파생 객체(자식)와 기반 객체(부모)의 멤버메서드가 중복될 시
 * 모호성이 발생되며 warning 경고를 호출한다.
 * => 부모자식이 같은 멤버가 있으면 부모 객체의 멤버를 은폐를 시켜야 한다.
 * 은폐 키워드 new를 사용
 */

class C
{
    public void f()
    {
        Console.WriteLine("aaa");
    }
}

class D : C
{
    // 클래스외부 new 공간할당       클래스내부 new -> 부모객체의 은폐
    new public void f()         // 자식객체의 메서드 앞에 new 키워드를 붙인다.
    {
        Console.WriteLine("bbb");
    }
}


class Program
{
    static void Main(string[] args)
    {

    }
}

