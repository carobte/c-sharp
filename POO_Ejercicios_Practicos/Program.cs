using POO_Ejercicios_Practicos.Models;

// Clase básica

var person = new Person("Caro", "Bte", "caro@example.com", "+573127862453");
person.Greet();
Console.WriteLine($"{person.Name}");
person.ShowContactInfo();

// Clase Estudiante

var Students = new List<Student>();
Students.Add(Student.GetStudent());
Students.Add(Student.GetStudent());
Students.Add(Student.GetStudent());
Students.Add(Student.GetStudent());

Console.WriteLine("Students...");

foreach (var student in Students)
{
    Console.WriteLine(@$"Name: {student.Name}, Age: {student.Age}, Status: {student.Registration}");
}


