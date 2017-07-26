using System;

class Cow
{
    private Action mooing;
    public event Action Mooing
    {
        add {
            mooing += value; 
            mooing += value; 
            Console.WriteLine("adddding"); 
         }
        remove { 
            mooing -= value; 
            Console.WriteLine("removvvving");
        }
    }

    public void PushSleepingCow()
    {
        // .....
        if (mooing!= null){
            mooing(); 
        }
    }

}

class MainClassFive
{
    static void Main()
    {
        Cow c = new Cow();
        c.Mooing += () => Console.WriteLine("Giggle"); 

        c.PushSleepingCow(); 
    }
}