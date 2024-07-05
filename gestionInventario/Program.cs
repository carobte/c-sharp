using System;

public class Producto
{
    public string Nombre { get; set; }
    public double PrecioUnitario { get; set; }
    public int Cantidad { get; set; }

    public Producto(string nombre, double precioUnitario, int cantidad)
    {
        Nombre = nombre;
        PrecioUnitario = precioUnitario;
        Cantidad = cantidad;
    }

    public double CalcularTotal()
    {
        return PrecioUnitario * Cantidad;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Precio Unitario: {PrecioUnitario}, Cantidad: {Cantidad}";
    }
}

public class Program
{
    static List<Producto> inventario = new List<Producto>();

    public static void Main(string[] args)
    {
        // Ingresar tres productos inicialmente
        inventario.Add(new Producto("Manzanas", 1.53, 50));
        inventario.Add(new Producto("Naranjas", 2.00, 40));
        inventario.Add(new Producto("Bananas", 1.20, 100));

        while (true)
        {
            MostrarMenu();

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    LimpiarConsola();
                    AgregarProducto();
                    break;
                case "2":
                    LimpiarConsola();
                    ModificarProducto();
                    break;
                case "3":
                    LimpiarConsola();
                    EliminarProducto();
                    break;
                case "4":
                    LimpiarConsola();
                    MostrarInventario();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    Pausar();
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("###############################################################################################");
        Console.WriteLine("#                                        INVENTARIO                                           #");
        Console.WriteLine("###############################################################################################");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Modificar producto");
        Console.WriteLine("3. Eliminar producto");
        Console.WriteLine("4. Listar productos");
        Console.WriteLine("5. Salir");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.Write("INGRESE OPCION: ");
    }

    static void LimpiarConsola()
    {
        Console.Clear();
    }

    static void AgregarProducto()
    {
        Console.Write("Ingrese el nombre del producto: ");
        var nombre = Console.ReadLine();
        
        Console.Write("Ingrese el precio unitario del producto: ");
        var precioUnitario = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad inicial del producto: ");
        var cantidad = int.Parse(Console.ReadLine());

        var producto = new Producto(nombre, precioUnitario, cantidad);
        inventario.Add(producto);

        Console.WriteLine("Producto agregado correctamente.");
        Pausar();
    }

    static void ModificarProducto()
    {
        MostrarListadoProductos();

        Console.Write("Ingrese el número de producto que desea modificar (0 para salir): ");
        int numeroProducto = int.Parse(Console.ReadLine());

        if (numeroProducto == 0)
        {
            return;
        }

        if (numeroProducto < 1 || numeroProducto > inventario.Count)
        {
            Console.WriteLine("Número de producto no válido.");
            Pausar();
            return;
        }

        var producto = inventario[numeroProducto - 1];

        Console.Write($"Ingrese la nueva cantidad disponible para {producto.Nombre} (anterior: {producto.Cantidad}): ");
        int nuevaCantidad = int.Parse(Console.ReadLine());

        producto.Cantidad = nuevaCantidad;

        Console.WriteLine("Stock actualizado correctamente.");
        Pausar();
    }

    static void EliminarProducto()
    {
        MostrarListadoProductos();

        Console.Write("Ingrese el número de producto que desea eliminar (0 para salir): ");
        int numeroProducto = int.Parse(Console.ReadLine());

        if (numeroProducto == 0)
        {
            return;
        }

        if (numeroProducto < 1 || numeroProducto > inventario.Count)
        {
            Console.WriteLine("Número de producto no válido.");
            Pausar();
            return;
        }

        var producto = inventario[numeroProducto - 1];
        inventario.Remove(producto);

        Console.WriteLine("Producto eliminado correctamente.");
        Pausar();
    }

    static void MostrarInventario()
    {
        MostrarListadoProductos();

        double totalGeneral = inventario.Sum(p => p.CalcularTotal());
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine($"TOTAL GENERAL => {totalGeneral,50:C2}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
        Console.ReadKey();
    }

    static void MostrarListadoProductos()
    {
        Console.WriteLine("###############################################################################################");
        Console.WriteLine("#                                   LISTADO DE PRODUCTOS                                      #");
        Console.WriteLine("###############################################################################################");
        Console.WriteLine("Nro | Nombre                                   | Valor           | Cantidad   | Total");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");

        for (int i = 0; i < inventario.Count; i++)
        {
            var producto = inventario[i];
            Console.WriteLine($"{i + 1, -4} | {producto.Nombre, -40} | {producto.PrecioUnitario, 15:C2} | {producto.Cantidad, 10} | {producto.CalcularTotal(), 10:C2}");
        }
    }

    static void Pausar()
    {
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}