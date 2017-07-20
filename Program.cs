using System;
using System.Threading; 
using System.Runtime.InteropServices.ComTypes;

namespace DelegatePractice
{

    delegate void MyDelegate(string s); 
    class MyClass
    {
        public static void Hello(string s){
            Console.WriteLine("   Hello, {0}", s); 
        }

        public static void Goodbye(string s){
            Console.WriteLine("  Goodbye, {0}!", s); 
        }



        // public delegate void SecondDelegate(char a, char b); 
        static void Main(string[] args)
        {
            MyDelegate a, b, c, d; 

            // Create the delegate objest a that references the method Hello:
            a = new MyDelegate(Hello); 
            b = new MyDelegate(Goodbye); 

            // The two delegates, a and b, are compsed to form c: 
            c = a + b; 

            d = c - a; 

            Console.WriteLine("Invoking delegate a ");
            a("A"); 
            Console.WriteLine("Invoking delegate b ");
            b("B");
            Console.WriteLine("Invoking delegate c ");
            c("C"); 
            Console.WriteLine("Invoking delegate d ");
            d("D");

        }
    }
}
            

