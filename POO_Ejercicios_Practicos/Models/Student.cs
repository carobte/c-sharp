using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios_Practicos.Models
{
    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Registration { get; set; }

        public Student(string name, int age, string registration)
        {
            this.Name = name;
            this.Age = age;
            this.Registration = registration;
        }

        public static Student GetStudent()
        {
            Console.WriteLine("Name of the student: ");
            var name = Console.ReadLine();

            Console.WriteLine("Age of the student: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Registration of the student: ");
            var registration = Console.ReadLine();
            return new Student(name, age, registration);
        }
    }
}