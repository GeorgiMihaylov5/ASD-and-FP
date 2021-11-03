using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDataSearch
{
    public class Search
    {
        public static void SearchStudent(Student[] student, string name, int min, int max)
        {
            //Закръглям до горното най-голямо число, защото иначе ми дава грешка
            //int mid = (int)Math.Ceiling(min + (max - min) / 2d);
            int mid = min + (max - min) / 2;

            if (student[mid].FirstName == name)
            {
                Console.WriteLine($"Found number: {student[mid]}");
                return;
            }
            if (student[mid].FirstName.CompareTo(name) > 0)
                
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }

            if (max >= min)
            {
                SearchStudent(student, name, min, max);
            }
            else
            {
                Console.WriteLine("Eror 404! Not Found");
                return;
            }
        }
    }
}
