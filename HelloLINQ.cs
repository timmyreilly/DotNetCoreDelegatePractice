using System; 
using System.Linq; 

class MainLinq
{
    static void Main()
    {
        int [] numbers = new [] { 1, 3, 6, 2, 5, 1, 2, 1}; 
        var result = 
            from n in numbers 
            where n < 5
            select n; 
        foreach(int i in result){
            Console.WriteLine(i); 
        }
    }
}