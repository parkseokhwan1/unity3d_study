using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 인터페이스 : 상속관계가 없는 클래스에 기능(형태)를 제공
 * -> 메서드, 멤버변수들을 정의하고 차용하는 클래스가 구현을 담당함
 * 클래스와 비슷한 구조이며, 해당 인터페이스의 멤버는
 * 메서드, 프로퍼티, 인덱서만 받을 수 있음.
 * 해당 인터페이스를 차용 후 클래스에 구현하는 형태
 * 
 * <사용 1> - 인터페이스 정의
 * 클래스 키워드대신 인터페이스(interface) 키워드 사용.
 * {
 *      메서드 프로토 타입();
 * }
 * <사용 2>
 * class 인터페이스를 차용할 클래스명 : 인터페이스이름
 * {
 *      로직부
 *      정의된 메서드를 구현
 * }
 */

interface A
{
    void say();             // 메서드
    int prop { get; set; }  // 속성
}

class X : A
{
    public int b;
    public void say()
    {
        Console.WriteLine("인터페이스 내용을 구현");
    }
    public int prop
    {
        get { return b; }
        set { b = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        X x = new X();
        x.say();
        x.prop = 52;
        Console.WriteLine(x.prop);
    }
}

