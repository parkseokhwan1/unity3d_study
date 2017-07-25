using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex02
{
    class Temp
    {
        // 접근권한, 클래스 내부에서는 모든 데이터의 접근이 가능
        // 하지만 클래스 외부에서는?
        //       만약 현재클래스를 기준으로 기능을 추가했다면
        //       기능추가한 클래스는 기반 클래스의 자료형을 쓸 수 있는가?
        // public, private, protected
        // 외 O      X         X      (해당 클래스를 기반으로 => 기능추가된 클래스는
        //                              접근이 가능) => 상속의 개념
        // 내 O      O         O
        // oop 특징 - (캡슐화, 은닉화), 상속, 다형성
        public int a;
        private int b;
        protected int c;
        int d;              // 아무것도 안쓰면 private 속성을 가진다.
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
