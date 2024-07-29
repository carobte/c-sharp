using Taller_Practico_POO.Models;

// Datos quemados de ejemplo para estudiantes y profesores 
AdminApp.AgregarEstudiantesEj();
AdminApp.AgregarProfesoresEj();

// Bandera para el menu
var bandera = true;

// Bucle del menú con sus opciones
while (bandera)
{
    AdminApp.ImprimirMenu();
    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            bandera = false;
            Console.WriteLine("¡Hasta luego!");
            break;
        case "1":
            var estudianteNuevo = AdminApp.PedirDatosEstudiante();
            AdminApp.PedirCalificaciones(estudianteNuevo);
            AdminApp.AgregarEstudiante(estudianteNuevo);
            AdminApp.PausarMenu();
            break;
        case "2":
            var profesorNuevo = AdminApp.PedirDatosProfesor();
            AdminApp.PedirCursos(profesorNuevo);
            AdminApp.AgregarProfesor(profesorNuevo);
            AdminApp.PausarMenu();
            break;
        case "3":
            AdminApp.MostrarEstudiantes(AdminApp.Estudiantes);
            AdminApp.PausarMenu();
            break;
        case "4":
            AdminApp.MostrarProfesores(AdminApp.Profesores);
            AdminApp.PausarMenu();
            break;
        case "5":
            AdminApp.EditarEstudiante();
            AdminApp.PausarMenu();
            break;
        case "6":
            AdminApp.EditarProfesor();
            AdminApp.PausarMenu();
            break;
        case "7":
            var estudianteEliminar = AdminApp.BuscarEstudiante();
            AdminApp.EliminarEstudiante(estudianteEliminar);
            AdminApp.PausarMenu();
            break;
        case "8":
            var profesorEliminar = AdminApp.BuscarProfesor();
            AdminApp.EliminarProfesor(profesorEliminar);
            AdminApp.PausarMenu();
            break;
        case "9":
            LINQ.MenuLINQ(AdminApp.Estudiantes, AdminApp.Profesores);
            break;
        default:
            Console.WriteLine("Opción incorrecta, intenta de nuevo.");
            break;
    }
}