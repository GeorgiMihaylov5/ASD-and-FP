using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDataSearch
{
    public class Student
    {
        //Student constructor
        public Student(string firstName, string secondName, string lastName, int age, int grade, string address, string phoneNumber)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
        //Student properties
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        //Student ovveride function for print
        public override string ToString()
        {
            return $"{FirstName} {SecondName} {LastName} {Age} {Grade} {Address} {PhoneNumber}";
        }
    }
}
