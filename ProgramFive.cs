using System;

namespace DelegatePricate
{

    delegate void MeDelegate();

    class MainClassTwo
    {
        static void Main()
        {
            MeDelegate d = Foo;
            d = (MeDelegate)Delegate.Combine(d, new MeDelegate(Goo)); 
            d += Goo; 
            d += Sue;
            d(); 
        }

        static void Foo() { Console.WriteLine("Foo()"); }
        static void Goo() { Console.WriteLine("Goo()"); }
        static void Sue() { Console.WriteLine("Sue()"); }
    }
}