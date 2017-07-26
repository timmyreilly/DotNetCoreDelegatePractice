using System;
using System.Collections.Generic; 


public enum CowState
{
    Awake, Sleeping, Dead
}

class CowTippedEventArgs : EventArgs
{
    public CowState CurrentCowState {get; private set;}
    public CowTippedEventArgs(CowState currentState)
    {
        CurrentCowState = currentState; 
    }
}
class Cow
{
    private Action mooing;
    public string Name {get; set;}
    public EventHandler<CowTippedEventArgs> Coo; 
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
        // Logic... current state of the cow. 
        if(Coo != null){
            Coo(this, new CowTippedEventArgs(CowState.Awake));
        }
    }

}

class MainClassFive
{
    static void MainA()
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
    static void Gigg(object sender, CowTippedEventArgs e){
        Cow c = sender as Cow; 

        Console.WriteLine("Gig gig. we made " + c.Name + " moo!"); 

        switch(e.CurrentCowState){
            case CowState.Awake:
                Console.WriteLine("Run!");
                break;
            case CowState.Sleeping:
                Console.WriteLine("Tickle it");
                break;
            case CowState.Dead:
                Console.WriteLine("Butcher it"); 
                break;
        }
    }
}