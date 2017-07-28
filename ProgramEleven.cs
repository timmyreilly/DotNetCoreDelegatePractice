using System; 
using System.Collections.Generic; 

class MainEleven
{
    static Random rand = new Random(); 
    static IEnumerable<int> GetRandomNumbers(int count)
    {
        for(int i = 0; i < count; i++){
            yield return rand.Next(); 
        }

    }
    
    static void Main(){
        foreach(int num in GetRandomNumbers(10)){
            Console.WriteLine(num); 
        }
    }
}