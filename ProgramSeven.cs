using System;
using System.Collections.Generic;

namespace DelegatePractice
{

    public class TrainSignal
    {
        public Action TrainsAComing;
        public void HereComesATrain()
        {
            if(TrainsAComing != null)
                TrainsAComing(); 
        }
    }

    // delegate v event
    // an event is delegate reference with 2 restrictions. One you can not invoke the 
    // delegate reference directly and you can't assign to it directly 

    class Car {
        public Car(TrainSignal trainSignal){
            trainSignal.TrainsAComing += StopTheCar; // Observer pattern
        }

        private void StopTheCar(){
            Console.WriteLine("Screeeetch"); 
        }
    }
    public class MainClassFour
    {
        static void MainA()
        {
            Console.WriteLine("MainClassFour -> MainA");

            TrainSignal trainSignal = new TrainSignal();
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);

            trainSignal.HereComesATrain(); 
            Console.WriteLine("***"); 
            trainSignal.TrainsAComing(); 
            Console.WriteLine("***"); 
            trainSignal.TrainsAComing = null; 
            trainSignal.HereComesATrain(); 


        }

        // Wrestling with the concepts







    }

}