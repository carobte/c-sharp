using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public static class LINQ
    {
        public static void MenuLINQ(List<Estudiante> Estudiantes, List<Profesor> Profesores) // Impresión del menú
        {
            var bandera = true;
            while (bandera)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                               Busquedas LINQ                                            ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                             1. Filtrar por promedio > 85                                ");
                Console.WriteLine("                             2. Profesores con más de un curso                           ");
                Console.WriteLine("                             3. Estudiantes mayores a 16 años                            ");
                Console.WriteLine("                             4. Ordenar estudiantes por apellido asc                     ");
                Console.WriteLine("                             5. Salario de todos los profesores                          ");
                Console.WriteLine("                             6. Calificación más alta                                    ");
                Console.WriteLine("                             7. Cantidad de estudiantes por curso                        ");
                Console.WriteLine("                             8. Profesores con más de 10 años                            ");
                Console.WriteLine("                             9. Obtener asignaturas únicas                               ");
                Console.WriteLine("                            10. Estudiantes con acudiente llamada María                  ");
                Console.WriteLine("                            11. Ordenar profesores por salario desc                      ");
                Console.WriteLine("                            12. Promedio de edad de estudiantes                          ");
                Console.WriteLine("                            13. Profesores de Matemáticas                                ");
                Console.WriteLine("                            14. Estudiantes con más de 3 calificaciones registradas.     ");
                Console.WriteLine("                            15. Promedio de antigüedad de todos los profesores.                    ");
                Console.WriteLine("                             0. Salir                                                    ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("Selecciona una opción: ");

                var opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "0":
                        bandera = false;
                        break;
                    case "1":
                        var promedioMayor85 = Estudiantes.Where(estudiante => estudiante.Calificaciones.Average() > 85).ToList();
                        Console.WriteLine($"Estudiantes con promedio mayor a 85: ");
                        AdminApp.MostrarEstudiantes(promedioMayor85);
                        AdminApp.PausarMenu();
                        break;
                    case "2":
                        var profesoresMasDeUnCurso = Profesores.Where(p => p.Cursos.Count > 1).ToList();
                        Console.WriteLine($"Profesores con más de un curso: ");
                        AdminApp.MostrarProfesores(profesoresMasDeUnCurso);
                        AdminApp.PausarMenu();
                        break;
                    case "3":
                        var edadMayor16 = Estudiantes.Where(estudiante => estudiante.CalcularEdad() > 16).ToList();
                        Console.WriteLine($"Estudiantes con edad mayor a 16: ");
                        AdminApp.MostrarEstudiantes(edadMayor16);
                        AdminApp.PausarMenu();
                        break;
                    case "4":
                        var estudiantesOrdenados = Estudiantes.OrderBy(estudiante => estudiante.ObtenerApellido()).ToList();
                        AdminApp.MostrarEstudiantes(estudiantesOrdenados);
                        AdminApp.PausarMenu();
                        break;
                    case "5":
                        var totalSalario = Profesores.Sum(profesor => profesor.ObtenerSalario());
                        Console.WriteLine($"El salario total de los profesores es: {totalSalario:C} COP");
                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":

                        break;
                    case "10":

                        break;
                    case "11":

                        break;
                    case "12":

                        break;

                    case "13":

                        break;
                    case "14":

                        break;
                    case "15":

                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, intenta nuevamente");
                        break;

                }

            }

        }
    }
}