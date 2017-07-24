using System;
using System.Collections.Generic;

namespace DelegatePractice
{
    delegate bool MeDelegate(int n);

    public class MainClass
    {

        static bool LessThanFive(int n) { return n < 5; }
        static bool GreaterThanThirteen(int n) { return n > 13; }
        static void MainFour()
        {

            int[] numbers = new[] { 2, 4, 14, 235, 3, 1, 3, 6, 1 }; 

            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, LessThanFive);

            foreach (int n in result)
            {
                Console.WriteLine(n);
            }


        }


        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach(int number in numbers){
                if (gauntlet(number)){
                    yield return number; 
                }
            }
        }
    }


}