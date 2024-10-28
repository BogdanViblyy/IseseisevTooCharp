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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Action[] methods = new Action[] { Task1, Task2};
                Console.WriteLine("Sisestage ülesanne number");
                string numstr = Console.ReadLine();
                int number = int.Parse(numstr);
                methods[number - 1]();
            }
        }

        private static void Task1()
        {
            int rows = 5;
            int columns = 5;
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Algne massiiv:");
            PrintArray(array);

            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = array[i, j];
                }

                if (i % 2 == 0)
                    Array.Sort(row);
                else
                    Array.Sort(row, (a, b) => b.CompareTo(a));

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = row[j];
                }
            }

            Console.WriteLine("\nSortitud massiiv:");
            PrintArray(array);

            Console.Write("\nSisestage veeru number väljundiks (0 kuni " + (columns - 1) + "): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= columns)
            {
                Console.WriteLine("Vale veeru number.");
                return;
            }

            Console.WriteLine($"\nVäärtused veerus {k}:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(array[i, k]);
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void Task2()
        {
            Student[] students = new Student[5];

            // Populate the array with sample student data
            students[0] = new Student
            {
                FirstName = "Bogdan",
                LastName = "Viblyy",
                Group = "TARpv23",
                Subjects = new Subject[]
                {
                    new Subject { Name = "Matemaatika", Grades = new int[] { 5, 5, 5 } },
                    new Subject { Name = "Programmeerimine", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 5, 5, 5 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 5, 5, 5 } }
                }
            };

            students[1] = new Student
            {
                FirstName = "Artur",
                LastName = "Linder",
                Group = "VLOGpv24",
                Subjects = new Subject[]
                {
                    new Subject { Name = "Matemaatika", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Logistika", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 2, 2, 2 } }
                }
            };

            students[2] = new Student
            {
                FirstName = "Kirill",
                LastName = "Sats",
                Group = "TARpv23",
                Subjects = new Subject[]
                {
                    new Subject { Name = "Matemaatika", Grades = new int[] { 5, 4, 5 } },
                    new Subject { Name = "Programmeerimine", Grades = new int[] { 4, 5, 5 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 3, 2, 4 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 5, 4, 3 } }
                }
            };

            students[3] = new Student
            {
                FirstName = "Vladislav",
                LastName = "Kudrjashev",
                Group = "TARpv23",
                Subjects = new Subject[]
                {
                    new Subject { Name = "Matemaatika", Grades = new int[] { 3, 2, 4 } },
                    new Subject { Name = "Programmeerimine", Grades = new int[] { 2, 3, 4 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 4, 3, 5 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 3, 4, 2 } }
                }
            };

            students[4] = new Student
            {
                FirstName = "Aleksandr",
                LastName = "Nadvorny",
                Group = "TARpv23",
                Subjects = new Subject[]
                {
                    new Subject { Name = "Matematika", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Programmeerimine", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 2, 2, 2 } }
                }
            };
            List<Student> studentsForExpulsion = new List<Student>();


            foreach (var student in students)
            {
                int countOfBadSubjects = 0;
                foreach (var subject in student.Subjects)
                {
                    if (subject.Grades.Average() == 2.0)
                    { 
                        countOfBadSubjects++; 
                    }
                }
                if (countOfBadSubjects >= 3) 
                {
                    studentsForExpulsion.Add(student);
                }
                
            }
            Console.WriteLine("Väljaarvamisele minevad tudengid: \n");
            PrintList(studentsForExpulsion);


        }
        static void PrintList(List<Student> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine($"Eesnimi: {student.FirstName}\tPerenimi: {student.LastName}\tGrupp: {student.Group}\n");

                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($"  Aine: {subject.Name}, Hinned: {string.Join(", ", subject.Grades)}");
                }

                Console.WriteLine();
            }
        }

    }
}
