using Taller_Practico_POO.Models;


var bandera = true;

while (bandera)
{
    AdminApp.ImprimirMenu();
    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            bandera = false;
            break;
        case "1":
            var estudianteNuevo = AdminApp.PedirDatosEstudiante();
            AdminApp.PedirCalificaciones(estudianteNuevo);
            AdminApp.AgregarEstudiante(estudianteNuevo);
            AdminApp.PausarMenu();
            break;
        case "2":
            // Agregar Profesor
            AdminApp.PausarMenu();
            break;
        case "3":
            AdminApp.MostrarEstudiantes();
            AdminApp.PausarMenu();
            break;
        case "4":
            // Mostrar Profesores
            AdminApp.PausarMenu();
            break;
        case "5":
            // Editar estudiante
            break;
        case "6":
            // Editar profesor
            break;
        case "7":
            // Eliminar estudiante
            break;
        case "8":
        // Eliminar profesor
        default:
            break;
    }
}