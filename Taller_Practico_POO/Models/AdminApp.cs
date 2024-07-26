using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public static class AdminApp
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>(); // Lista para guardar los estudiantes
        public static List<Profesor> Profesores = new List<Profesor>(); // Lista para guardar los profesores

        public static void EditarEstudiante()
        {
            var estudianteEncontrado = BuscarEstudiante();
            Estudiante.EditarEstudiante(estudianteEncontrado);
            Console.WriteLine($"El estudiante {estudianteEncontrado.ObtenerNombre()} fue editado satisfactoriamente");
        }

        public static void EditarProfesor()
        {
            var profesorEncontrado = BuscarProfesor();
            Profesor.EditarProfesor(profesorEncontrado);
            Console.WriteLine($"El profesor {profesorEncontrado.ObtenerNombre()} fue editado satisfactoriamente");
        }

        public static Estudiante PedirDatosEstudiante() // Solicitamos los datos de un estudiante
        {
            Console.WriteLine("Ingrese los datos del estudiante:");

            Console.WriteLine("Nombre: ");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            string? apellido = Console.ReadLine();

            Console.WriteLine("Tipo de documento: ");
            string? tipoDocumento = Console.ReadLine();

            Console.WriteLine("Número de documento: ");
            string? numeroDocumento = Console.ReadLine();

            Console.WriteLine("Email: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Teléfono: ");
            string? telefono = Console.ReadLine();

            Console.WriteLine("Nombre Acudiente: ");
            string? nombreAcudiente = Console.ReadLine();

            Console.WriteLine("Curso: ");
            string? curso = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de nacimiento del estudiante: año/mes/día ");
            // Convertimos primero a DateTime para poder convertir a DateOnly
            DateOnly fechaNacimiento = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

            // se retorna una instancia de estudiante con los datos ingresados
            return new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, curso, fechaNacimiento);
        }

        public static Profesor PedirDatosProfesor() // solicitamos datos del profesor
        {
            Console.WriteLine("Ingrese los datos del profesor:");

            Console.WriteLine("Nombre: ");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            string? apellido = Console.ReadLine();

            Console.WriteLine("Tipo de documento: ");
            string? tipoDocumento = Console.ReadLine();

            Console.WriteLine("Número de documento: ");
            string? numeroDocumento = Console.ReadLine();

            Console.WriteLine("Email: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Teléfono: ");
            string? telefono = Console.ReadLine();

            Console.WriteLine("Asignatura: ");
            string? asignatura = Console.ReadLine();

            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la fecha de contratación del profesor: año/mes/día ");
            DateTime fechaContratacion = Convert.ToDateTime(Console.ReadLine()); // convertimos a DateTime

            // se retorna una instancia de profesor con los datos ingresados
            return new Profesor(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, asignatura, salario, fechaContratacion);
        }

        public static void AgregarEstudiantesEj() // Datos quemados de ejemplo.
        {
            var estudiante1 = new Estudiante("Juan", "Pérez", "CC", "12345678", "juan.perez@example.com", "555-1234", "María Pérez", "décimo", new DateOnly(2006, 5, 12));
            var estudiante2 = new Estudiante("María", "Gómez", "TI", "87654321", "maria.gomez@example.com", "555-5678", "Luis Gómez", "noveno", new DateOnly(2007, 8, 24));
            var estudiante3 = new Estudiante("Carlos", "Rodríguez", "CC", "11223344", "carlos.rodriguez@example.com", "555-9876", "Ana Rodríguez", "once", new DateOnly(2005, 3, 19));
            var estudiante4 = new Estudiante("Lucía", "Martínez", "TI", "44332211", "lucia.martinez@example.com", "555-6543", "Pedro Martínez", "octavo", new DateOnly(2008, 11, 5));
            var estudiante5 = new Estudiante("Pedro", "López", "CC", "99887766", "pedro.lopez@example.com", "555-3210", "Sofía López", "décimo", new DateOnly(2006, 1, 30));

            Estudiantes.Add(estudiante1);
            Estudiantes.Add(estudiante2);
            Estudiantes.Add(estudiante3);
            Estudiantes.Add(estudiante4);
            Estudiantes.Add(estudiante5);

            estudiante1.AgregarCalificaciones(75);
            estudiante1.AgregarCalificaciones(85);

            estudiante2.AgregarCalificaciones(85);
            estudiante2.AgregarCalificaciones(55);

            estudiante3.AgregarCalificaciones(65);
            estudiante3.AgregarCalificaciones(100);

            estudiante4.AgregarCalificaciones(90);
            estudiante4.AgregarCalificaciones(50);

            estudiante5.AgregarCalificaciones(95);
            estudiante5.AgregarCalificaciones(50);

        }

        public static void AgregarProfesoresEj() // Datos quemados de ejemplo
        {
            var profesor1 = new Profesor("Laura", "González", "CC", "123456789", "laura.gonzalez@example.com", "555-1111", "Matemáticas", 8000000, new DateTime(2015, 9, 1));
            var profesor2 = new Profesor("Jorge", "Martínez", "TI", "987654321", "jorge.martinez@example.com", "555-2222", "Historia", 8200000, new DateTime(2016, 3, 15));
            var profesor3 = new Profesor("Ana", "Rodríguez", "CC", "456123789", "ana.rodriguez@example.com", "555-3333", "Biología", 8500000, new DateTime(2017, 1, 10));

            Profesores.Add(profesor1);
            Profesores.Add(profesor2);
            Profesores.Add(profesor3);

            profesor1.AgregarCursos("sexto");
            profesor1.AgregarCursos("séptimo");
            profesor2.AgregarCursos("octavo");
            profesor2.AgregarCursos("décimo");
            profesor3.AgregarCursos("once");
            profesor3.AgregarCursos("noveno");
        }

        public static void PedirCalificaciones(Estudiante estudiante) // Pedimos calificaciones de cada estudiante y se le agregan
        {
            Console.WriteLine("Cuántas notas vas a agregar?: ");
            var notas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= notas; i++)
            {
                Console.WriteLine($"Escribe tu {i} nota: ");
                var nota = Convert.ToDouble(Console.ReadLine());
                estudiante.AgregarCalificaciones(nota);
            }
        }
        
        public static void AgregarEstudiante(Estudiante estudiante) // Se agrega el estudiante a la lista
        {
            Estudiantes.Add(estudiante);
            Console.WriteLine($"El estudiante fue añadido correctamente");
        }

        public static void PedirCursos(Profesor profesor) // se piden los cursos a los que va a estar asignado el profesor
        {
            Console.WriteLine($"Cuántas cursos vas a agregarle al {profesor.ObtenerNombre()}?: ");
            var cursos = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cursos; i++)
            {
                Console.WriteLine($"Escribe el {i} curso donde esté asignado: ");
                var curso = Console.ReadLine();
                profesor.AgregarCursos(curso); // se agregan los cursos
            }
        }

        public static void AgregarProfesor(Profesor profesor) // se agrega el profesor a la lista
        {
            Profesores.Add(profesor);
            Console.WriteLine($"El profesor fue añadido correctamente");
        }

        public static void MostrarEstudiantes() // se imprime la información de los estudiantes
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        public static void MostrarProfesores() // se imprime la información de los profesores
        {
            foreach (var profesor in Profesores)
            {
                profesor.MostrarDetalles();
            }
        }

        public static Estudiante BuscarEstudiante() // buscamos un estudiante específico para editar o eliminar
        {
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            var numDocumento = Console.ReadLine();
            return Estudiantes.Find(estudiante => estudiante.ObtenerNumDocumento() == numDocumento);
        }

        public static Profesor BuscarProfesor() // buscamos un profesor específico para editar o eliminar
        {
            Console.WriteLine("Ingresa el número de documento del profesor: ");
            var numDocumento = Console.ReadLine();
            return Profesores.Find(profesor => profesor.ObtenerNumDocumento() == numDocumento);
        }

        public static void EliminarEstudiante(Estudiante estudiante) // se elimina un estudiante de la lista 
        {
            Console.WriteLine($"¿Está seguro que desea eliminar a {estudiante.ObtenerNombre()}? (si/no)");
            var confirmacion = Console.ReadLine();
            if (confirmacion.Equals("si", StringComparison.CurrentCultureIgnoreCase)) // Valida el si sin importar mayus o minus.
            {
                Estudiantes.Remove(estudiante);
                Console.WriteLine($"El estudiante {estudiante.ObtenerNombre()} fue eliminado");
            }
        }

        public static void EliminarProfesor(Profesor profesor) // se elimina un profesor de la lista 
        {
            Console.WriteLine($"¿Está seguro que desea eliminar a {profesor.ObtenerNombre()}? (si/no)");
            var confirmacion = Console.ReadLine();
            if (confirmacion.Equals("si", StringComparison.CurrentCultureIgnoreCase)) // Valida el si sin importar mayus o minus.
            {
                Profesores.Remove(profesor);
                Console.WriteLine($"El profesor {profesor.ObtenerNombre()} fue eliminado");
            }
        }

        public static void ImprimirMenu() // impresión del menú
        {
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                           Gestión del sistema escolar                        ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                             1. Agregar Estudiante                            ");
            Console.WriteLine("                             2. Agregar Profesor                              ");
            Console.WriteLine("                             3. Mostrar Estudiantes                           ");
            Console.WriteLine("                             4. Mostrar Profesores                            ");
            Console.WriteLine("                             5. Editar Estudiante                             ");
            Console.WriteLine("                             6. Editar Profesor                               ");
            Console.WriteLine("                             7. Eliminar Estudiante                           ");
            Console.WriteLine("                             8. Eliminar Profesor                             ");
            Console.WriteLine("                             0. Salir                                         ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Selecciona una opción: ");

        }

        public static void PausarMenu() // generamos una pausa en el menú para mejorar la experiencia de usuario
        {
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
        }
    }
}