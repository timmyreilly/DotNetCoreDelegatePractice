using System;
using System.Collections.Generic; 

namespace DelegatePricate
{

    delegate void MeDelegate();
    delegate int AnotherDelegate(); 
    class MainClassTwo
    {
        static void MainA()
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

        static void Main()
        {
            AnotherDelegate d = ReturnFive; 
            d += ReturnTen; 
            d += ReturnTwentyTwo; 
            // int value = d(); 

            List<int> ints = new List<int>(); 
            foreach(AnotherDelegate del in d.GetInvocationList())
                ints.Add(del()); 

            foreach(int i in ints){
                Console.WriteLine(i);
            }
            //Console.WriteLine(value); 


        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() {return 10; }
        static int ReturnTwentyTwo() {return 22; }
        
    }


}