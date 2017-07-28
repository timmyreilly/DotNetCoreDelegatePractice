using System; 
using System.Collections.Generic; 

class MainEleven
{
    static Random rand = new Random(); 
    static IEnumerable<int> GetRandomNumbers(int count)
    {
        List<int> ints = new List<int>();
        for(int i = 0; i < count; i++){
            ints.Add(rand.Next()); 
        }

        return ints; 
    }
    
    static void Main(){
        foreach(int num in GetRandomNumbers(10)){
            Console.WriteLine(num); 
        }
    }
}