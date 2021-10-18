using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RealSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                Student student = new Student(input[0], input[1], input[2], int.Parse(input[3]), int.Parse(input[4]), input[5], input[6]);
                students.Add(student);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            students = Sort.SortArray(students.ToArray());
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Sorted students:");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Time: {stopwatch.ElapsedTicks} ticks");

            //INPUT
//            4
//Andrei Valentinov Vasilev 17 11 Sofia,BG 0898761233
//Georgi Ivanov Metodiev 18 12 Pernik,BG 0889875632
//Qvor Stefanov Stefanov 14 8 Burgas,BG 08978652410
//Andrei Bashkov Andreev 18 12 Pernik 0887268956
        }
    }
}
