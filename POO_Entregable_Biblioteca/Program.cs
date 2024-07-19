using POO_Entregable_Biblioteca.Models;

var biblioteca = new Biblioteca();

void Menu()
{
    CrearLibrosEJ();

    bool continuar = true; // Bandera para el menú
    while (continuar)
    {
        Console.WriteLine("======================================================================================");
        Console.WriteLine("                                  Menú de Biblioteca                                  ");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("0. Cerrar");
        Console.WriteLine("1. Mostrar libros");
        Console.WriteLine("2. Agregar libro");
        Console.WriteLine("3. Eliminar libro");
        Console.WriteLine("4. Buscar");
        Console.WriteLine("5. Ordenar libros por año de publicación");
        Console.WriteLine("6. Aplicar descuento a un libro"); // (?)
        Console.WriteLine("======================================================================================");

        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                biblioteca.MostrarLibros(biblioteca.Libros);
                PausarMenu();
                break;
            case "2":
                biblioteca.AgregarLibro();
                PausarMenu();
                break;
            case "3":
                biblioteca.EliminarLibro();
                PausarMenu();
                break;
            case "4":
                MenuBuscar();
                PausarMenu();
                break;
            case "5":
                biblioteca.OrdenarPorAño();
                PausarMenu();
                break;
            case "6":
                PausarMenu();
                break;
            case "0":
                Console.WriteLine("Hasta luego, vuelva pronto");
                continuar = false; // Rompemos el ciclo
                break;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo");
                break;
        }
    }
}

void MenuBuscar()
{
    Console.WriteLine("======================================================================================");
    Console.WriteLine("                                  Menú de Buscar                                  ");
    Console.WriteLine("======================================================================================");
    Console.WriteLine("0. Volver a menú principal");
    Console.WriteLine("1. Buscar por género");
    Console.WriteLine("2. buscar por autor");
    Console.WriteLine("3. Buscar por rango de año");
    Console.WriteLine("Elige una opcion:");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            biblioteca.BuscarPorGenero();
            PausarMenu();
            break;
        case "2":
            biblioteca.BuscarPorAutor();
            PausarMenu();
            break;
        case "3":
            biblioteca.BuscarPorAños();
            PausarMenu();
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Opción incorrecta, intenta de nuevo");
            break;
    }
}

void PausarMenu()
{
    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();
}

// Libros quemados para probar métodos 
void CrearLibrosEJ()
{

    var nuevoLibro1 = new Libro("J.K Rowling", "fantasia, magia", 65000, 1997, "Harry Potter y la piedra filosofal ");
    var nuevoLibro2 = new Libro("J.K Rowling", "fantasia", 65000, 1998, "Harry Potter y la cámara secreta");
    var nuevoLibro3 = new Libro("J.K Rowling", "fantasia", 65000, 1999, "Harry Potter y el prisionero de Azkaban");
    var nuevoLibro4 = new Libro("Emily Bronte", "novela", 65000, 1847, "Cumbres Borrascosas");

    biblioteca.Libros.Add(nuevoLibro1);
    biblioteca.Libros.Add(nuevoLibro2);
    biblioteca.Libros.Add(nuevoLibro3);
    biblioteca.Libros.Add(nuevoLibro4);

}

Menu(); // Ejecución Menu