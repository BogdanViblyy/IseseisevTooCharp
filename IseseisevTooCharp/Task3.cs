using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevTooCharp
{
    internal class Task3
    {
        public static void Execute()
        {
            List<string> employees = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };
            List<int> salaries = new List<int>
            {
                1200,
                2500,
                750,
                395,
                1200
            };
            bool keepRunning = true;
            int indexToRemove = 0;
            int indexOfSameSalaries = 0;
            while (keepRunning)
            {
                Console.WriteLine("Menüü:");
                Console.WriteLine("1 - Kuva töötajad ja nende palgad");
                Console.WriteLine("2 - Kustuta töötaja, ja tema palg");
                Console.WriteLine("3 - Kuva, kes saab kõige suurem palg");
                Console.WriteLine("4 - Kuva, millised töötajad saavad sama suguse palga");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        foreach (string employee in employees)
                        {
                            Console.Write(employee + ", ");
                        }
                        Console.WriteLine();
                        foreach (int salarie in salaries)
                        {
                            Console.Write(salarie);
                            Console.Write(", ");
                        }
                        Console.WriteLine();
                        break;




                    case "2":
                        foreach (string employee in employees)
                        {
                            Console.Write(employee + ", ");
                        }
                        Console.WriteLine();
                        foreach (int salarie in salaries)
                        {
                            Console.Write(salarie);
                            Console.Write(", ");
                        }
                        Console.WriteLine();                       
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Sisestage töötaja, keda te tahate kustutada:");
                                string employeeToRemove = Console.ReadLine();
                                if (employees.Contains(employeeToRemove))
                                {
                                    indexToRemove = employees.IndexOf(employeeToRemove);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Vale töötaja. Proovige uuesti.");
                                    
                                }
                                  
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Vale format.");
                            }
                            
                        }
                        employees.RemoveAt(indexToRemove);
                        salaries.RemoveAt(indexToRemove);
                        Console.WriteLine("Töötaja kustutatud. Uuendatud listid:");
                        Console.WriteLine();
                        foreach (string employee in employees)
                        {
                            Console.Write(employee + ", ");
                        }
                        Console.WriteLine();
                        foreach (int salary in salaries)
                        {
                            Console.Write(salary);
                            Console.Write(", ");
                        }
                        Console.WriteLine();
                        break;




                    case "3":
                        int largestSalary = salaries.Max();
                        int largestSalaryIndex = salaries.IndexOf(largestSalary);

                        Console.WriteLine($"Kõige suurema palgaga töötaja on {employees[largestSalaryIndex]}, tema palk on {salaries[largestSalaryIndex]}");
                        break;




                    case "4":
                        for (int i = 0; i < salaries.Count; i++)
                        {
                            bool alreadyProcessed = false;
                            int countEmployeesWithThisSalary = 0;
                            
                            for (int j = 0; j < salaries.Count; j++)
                            {
                                if (salaries[j] == salaries[i])
                                {
                                    countEmployeesWithThisSalary++;
                                    if (j < i)
                                    {
                                        alreadyProcessed = true;
                                    }
                                        
                                }
                            }
                           
                            if (countEmployeesWithThisSalary > 1 && !alreadyProcessed)
                            {
                                Console.Write($"Tootajad palgaga {salaries[i]}: ");
                                for (int j = 0; j < salaries.Count; j++)
                                {
                                    if (salaries[j] == salaries[i])
                                    {
                                        Console.Write(employees[j] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        break;



                }
            }
        }

    }
}
