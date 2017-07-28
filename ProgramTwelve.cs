using System; 

static class MainTwelve{
    // Extension methods! 
    static DateTime Combine(this DateTime datePart, DateTime timePart){
        return new DateTime(
            datePart.Year, datePart.Month, datePart.Day, 
            timePart.Hour, timePart.Minute, timePart.Second);
    }

    static void MainA(){
        DateTime date = DateTime.Parse("1/5/2025"); 
        DateTime time = DateTime.Parse("1/1/0001 9:55"); 
        DateTime combined = Combine(date, time); 
        DateTime combined2 = date.Combine(time); 

        Console.WriteLine($"{combined} or {combined2}"); 
    }

    class Cow{
        static int numMoos; 
        public static void Moo(Cow _this){
            numMoos++;
            Console.WriteLine("Mooooo" + numMoos); 
        }
    }

    static void Main(){
        Cow c1 = new Cow(); 
        Cow c2 = new Cow(); 

        Cow.Moo(c1); 
        Cow.Moo(c2); 
        Cow.Moo(c2); 
        Cow.Moo(c2); 
        
    }
}