using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios_Practicos.Models
{
    public class Person
    {
        private Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        protected string? Email { get; set; }
        public string Phone { get; set; }

        public Person(string name, string lastName, string email, string phone)
        {
            this.Id = new Guid();
            Name = name;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public void Greet(){
            Console.WriteLine($"Hello, I'm {Name} {LastName}, my email is {Email}");
        }

        public void ShowContactInfo(){
            Console.WriteLine(@$"Contact Information for {Name}:
            Email: {Email},
            Phone: {Phone}");
        }

    }
}