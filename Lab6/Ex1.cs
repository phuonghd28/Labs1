using System;

namespace Lab6
{
    public delegate void MyDelegate(int a ,int b ,int c);
    public class Ex1
    {
        

        public static void Add2(int x)
        {
            x+=2;
        }

        public void Add3(int x)
        {
            x+=3;
        }

        public void Tong3So(int a ,int b ,int c)
        {
            Console.WriteLine($"{a}+{b}+{c}={a+b+c}");
        }
    }
}