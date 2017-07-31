using System;

static class MainTwelve
{
    // Extension methods! 
    static DateTime Combine(this DateTime datePart, DateTime timePart)
    {
        return new DateTime(
            datePart.Year, datePart.Month, datePart.Day,
            timePart.Hour, timePart.Minute, timePart.Second);
    }

    static void MainA()
    {
        DateTime date = DateTime.Parse("1/5/2025");
        DateTime time = DateTime.Parse("1/1/0001 9:55");
        DateTime combined = Combine(date, time);
        DateTime combined2 = date.Combine(time);

        Console.WriteLine($"{combined} or {combined2}");
    }

    static void MainB()
    {
        Cow2 c1 = new Cow2();
        Cow2 c2 = new Cow2();

        c1.Moo();
        c1.Moo();
        c1.Moo();
        c2.Moo();
        

    }
}
// static extension methods 
class Cow2
{
    public int numMoos;
}

static class CowMethods
{
    public static void Moo(this Cow2 _this)
    {
        _this.numMoos++;
        Console.WriteLine("Mooooo" + _this.numMoos);
    }
}