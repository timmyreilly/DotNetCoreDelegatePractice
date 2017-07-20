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
            
            DelegateTest t= new DelegateTest(); 

            t.MyEvent += new EventHandler(t.DoNothing); 
            t.MyEvent -= null; 

        }

        static string StaticMethod(int i){
            return string.Format ("Static method: {0}", i);  
        }

        string InstanceMethod(int i){
            return string.Format("{0}: {1}", name, i); 
        }

        public event EventHandler MyEvent
        {
            add {
                Console.WriteLine("Add operation"); 
            }

            remove {
                Console.WriteLine ("remove operation"); 
            }
        }

        void DoNothing (object sender, EventArgs e){

        }
    }
}
