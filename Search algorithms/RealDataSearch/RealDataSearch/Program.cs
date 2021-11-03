using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RealDataSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            //-----------------Ръчно въвеждане на ученици-------------------


            //Console.Write("Count of new students: ");
            //var n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    var input = Console.ReadLine().Split().ToArray();

            //    Student student = new Student(input[0], input[1], input[2], int.Parse(input[3]), int.Parse(input[4]), input[5], input[6]);
            //    students.Add(student);
            //}
       

            students.Add(new Student("Andrei", "Valentinov", "Vasilev", 17, 11, "Sofia, BG", "089876123"));
            students.Add(new Student("Georgi", "Ivanov", "Metodiev", 18, 12, "Pernik,BG", "0889875632"));
            students.Add(new Student("Qvor", "Stefanov", "Stefanov", 14, 8, "Burgas,BG", "0897865241"));
            students.Add(new Student("Andrei", "Bashkov", "Andreev", 18, 12, "Pernik,BG", "0887268956"));

            Console.WriteLine(new string('-',50));
            Console.WriteLine("Students");
            Console.WriteLine(new string('-', 50));

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            students = Sort.SortArray(students.ToArray());

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine();
            Console.Write("Count of searched students: ");
            var searchedStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < searchedStudents; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                stopwatch.Start();
                Search.SearchStudent(students.ToArray(), name, 0, students.Count);
                stopwatch.Stop();
                Console.WriteLine();
            }

            Console.WriteLine($"All ticks: {stopwatch.ElapsedTicks}");
            Console.WriteLine($"Average ticks: {stopwatch.ElapsedTicks / searchedStudents}");

            
        }
    }
}
//4
//Andrei Valentinov Vasilev 17 11 Sofia, BG 0898761233
//Georgi Ivanov Metodiev 18 12 Pernik, BG 0889875632
//Qvor Stefanov Stefanov 14 8 Burgas, BG 08978652410
//Andrei Bashkov Andreev 18 12 Pernik, BG 0887268956
