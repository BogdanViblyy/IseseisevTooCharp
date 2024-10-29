using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevTooCharp
{
    internal class Task2
    {
        public static void Execute()
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
                    new Subject { Name = "Matemaatika", Grades = new int[] { 3, 2, 5 } },
                    new Subject { Name = "Logistika", Grades = new int[] { 2, 2, 2 } },
                    new Subject { Name = "Keelekirjandus", Grades = new int[] { 2, 4, 2 } },
                    new Subject { Name = "Inglise keel", Grades = new int[] { 5, 3, 2 } }
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
