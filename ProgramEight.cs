using System;

class Cow
{
    private Action mooing;
    public string Name {get; set;}
    public EventHandler Coo; 
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

    public void BeTippedOver(){
        if(Coo != null){
            Coo(this, EventArgs.Empty);
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

        Cow c1 = new Cow{Name = "Betsy"};
        c1.Coo += Gigg; 
        Cow c2 = new Cow{Name = "Georgie"};
        c2.Coo += Gigg; 

        Cow victum = new Random().Next() % 2 == 0 ? c1 : c2; 

        victum.BeTippedOver(); 
        
    }

    // This is an event handler  
    static void Gigg(object sender, EventArgs e){
        Cow c = sender as Cow; 
        Console.WriteLine("Gig gig. we made " + c.Name + " moo!"); 
    }
}