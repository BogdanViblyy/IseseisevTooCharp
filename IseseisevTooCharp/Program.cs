using IseseisevTooCharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IseseisevTooCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Valige ülesanne:");
                Console.WriteLine("1 - Ülesanne 1");
                Console.WriteLine("2 - Ülesanne 2");
                Console.WriteLine("3 - Ülesanne 3");
                Console.WriteLine("0 - Välju");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1.Execute();
                        break;
                    case "2":
                        Task2.Execute();
                        break;
                    case "3":
                        Task3.Execute();
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Vale valik, proovige uuesti.");
                        break;
                }

            }
        }
    }
}
