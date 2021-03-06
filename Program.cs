﻿using System;

namespace DelegatePractice
{
    class Program 
    {
        public static void LogToConsole(string message){
            Console.WriteLine(message); 
        }

        public static void MainOne(string[] args)
        {
            Logger.WriteMessage += LogToConsole; 

            var file = new FileLogger("log.txt");

            Logger.LogMessage(Severity.Warning, "Console", "This is a warning message"); 

            Logger.LogMessage(Severity.Information, "Console", "Information message one"); 

            Logger.LogLevel = Severity.Information; 

            Logger.LogMessage(Severity.Information, "Console", "Information message two"); 
        }
    }
}



