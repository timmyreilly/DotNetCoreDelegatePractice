using System;

namespace DelegatePractice
{
    public class MainClassThree{

        static void MainA(){
            Console.WriteLine("MainClassThree -> MainA");
            Action a = GiveMeAction(); 
            Action b = GiveMeAction(); 
            a(); 
            b(); 
            a();
            b(); 
            a(); 

        }

        // Closures in a nutshell 
        static Action GiveMeAction()
        {
            Action ret = null; 
            int i = 0; 
            ret += () => {
                Console.WriteLine("First Method " + i++); 
            };

            ret += () => {
                Console.WriteLine("Second Method " + i++); 
            };

            return ret; 
        }


    }
    
}