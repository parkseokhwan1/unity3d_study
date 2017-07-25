﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자, 소멸자
// 객체를 만들면 메모리공간 할당
// c - malloc(크기) => 공간은 할당이 되지만 내부에는 쓰레기 값으로 가득참
// 생성자 -> 객체의 생성 이후에 내부의 데이터를 초기화를 하기위해 호출되는 메서드
// 자동 혹은 수동으로 호출됨( 객체를 만들때만 )
// 객체가 만들어진 이후에는 생성자는 호출이 안됨
// 생성자 => 초기화 메서드
// 형식 : 리턴타입(x)     (클래스이름=)메서드명(파라미터)                       ***

/*
class A
{
    public int m_a;
    public A()         // 메서드인데 리턴타입 없음
    {
        m_a = 1;
    }

    public A(int setdata)         // 메서드인데 리턴타입 없음
 // 권한 클래스이름 //
 // 생성과 초기화는 클래스 외부, 외부에서 접근가능하도록 권한을 public으로
    {
        m_a = setdata;
    }

    // 생성과 초기화는 클래스 외부, 외부에서 접근가능하도록, 권한 - public
    public void showdata()
    {
        Console.WriteLine("m_a" + m_a);
    }
    
}
*/

class A
{
    public int m_a;
    // 생성자를 안만들었으니까, 시스템이 알아서 만들어 주겠지
    // 0으로 셋팅해 주겠지

    // 소멸자, 객체가 파괴될 때 호출되는 메서드 (알아서)
    // 사용자가 호출하지는 않음
    // 형태 - ~클래스이름()    => 중복정의 불필요(파괴상황), 리턴타입 불필요
    ~A() // 생성자
    {
        // 객체의 파괴시 처리할 루틴
        // m_a = 0;
        Console.WriteLine("파괴됨");
    }
    // 실제로는 소멸자를 셋팅하거나 코딩하는 경우는 별로 없음
    // 클래스 외부에서 호출여부(X)

}

namespace class_ex03_cd
{
    class Program
    {
        static void Main()
        {
            A ab = new A();
            Console.Write("111");
            Console.WriteLine("222");
        }
    }
}

/*
namespace class_ex03_cd
{
    class Program
    {
        static void Main(string[] args)
        {
            A ma;               // 객체의 생성? => 객체를 받기위한 변수(주소를 받는 변수)
            ma = new A(123);       // 객체의 공간을 만들고 초기화 하는 부분    -new-
            // 이후에는 생성자는 호출안됨
            // 생성자 사용
            // new 클래스이름(파라미터) // 메모리할당 + 생성자 호출 코드
            ma.showdata();
            // 클래스이름() 생성자를 아예 안만들경우 => 시스템이 알아서 자동으로 생성자를 만듬          ***
            // 알아서 초기화를 시킴 -> 0

            // 1개라도 있으면 객체를 만들때 해당 생성자를 써야 한다.
            A ma_1 = new A(486);

            // 기본클래스()  ;   // 파라미터가 없는 생성자는 스스로 다시 만들어야 사용할 수 있다.
            ma_1.showdata();
        }
    }
}
*/
