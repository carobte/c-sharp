using Taller_Practico_POO.Models;

AdminApp.AgregarEstudiantesEj();
AdminApp.AgregarProfesoresEj();
var bandera = true;

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
            AdminApp.MostrarEstudiantes();
            AdminApp.PausarMenu();
            break;
        case "4":
            AdminApp.MostrarProfesores();
            AdminApp.PausarMenu();
            break;
        case "5":
            // Editar estudiante
            break;
        case "6":
            // Editar profesor
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
        default:
            Console.WriteLine("Opción incorrecta, intenta de nuevo.");
            break;
    }
}