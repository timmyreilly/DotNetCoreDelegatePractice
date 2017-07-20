using System;

namespace DelegatePractice
{

    public delegate string FirstDelegate(int x); 
    class DelegateTest
    {
        string name; 

        // public delegate void SecondDelegate(char a, char b); 
        static void Main(string[] args)
        {
            
            FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);

            DelegateTest instance = new DelegateTest(); 
            instance.name = "My Intance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod); 

            Console.WriteLine(d1(10)); 
            Console.WriteLine(d2(5));

        }

        static string StaticMethod(int i){
            return string.Format ("Static method: {0}", i);  
        }

        string InstanceMethod(int i){
            return string.Format("{0}: {1}", name, i); 
        }
    }
}
