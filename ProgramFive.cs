using System;
using System.Collections.Generic; 

namespace DelegatePricate
{

    delegate void MeDelegate();
    delegate T AnotherDelegate<T>(); 
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
            Func<int> d = ReturnFive; 
            d += ReturnTen; 
            d += ReturnTwentyTwo; 
            // int value = d(); 

            Func<int, bool> f = TakeAnIntAndReturnABool;

            Action<int> a= GetString; 

            a(5); 

            Console.WriteLine(f(5)); 

            foreach(int i in GetAllReturnValues<int>(d)){
                Console.WriteLine(i);
            }
            //Console.WriteLine(value); 


        }

        static void GetString(int a){
            Console.WriteLine($"Hello world {a}"); 
        }

        static bool TakeAnIntAndReturnABool(int a){
            return true; 
        }

        static IEnumerable<T> GetAllReturnValues<T>(Func<T> d){
            foreach(Func<T> del in d.GetInvocationList())
                yield return del(); 
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() {return 10; }
        static int ReturnTwentyTwo() {return 22; }
        
    }


}