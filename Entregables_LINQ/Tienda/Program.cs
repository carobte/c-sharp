var listaVentas = new List<Venta>();

// Datos quemados 

var id = Guid.NewGuid();
var fecha = DateTime.Now;

var id2 = Guid.NewGuid();
var fecha2 = DateTime.Now;

var id3 = Guid.NewGuid();
var fecha3 = DateTime.Now;

var id4 = Guid.NewGuid();
var fecha4 = DateTime.Now;

listaVentas.Add(new Venta(id, fecha, "pc", 2500000, 2, "caro", "val", "1 año"));
listaVentas.Add(new Venta(id2, fecha2, "pc", 5000000, 1, "cami b", "santi", "1 año"));
listaVentas.Add(new Venta(id3, fecha3, "tv", 3000000, 1, "cami b", "cami c", "1 año"));
listaVentas.Add(new Venta(id4, fecha4, "nevera", 7000000, 1, "caro", "val", "1 año"));


void CrearVenta()
{
    var id = Guid.NewGuid();
    var fecha = DateTime.Now;

    Console.WriteLine("Ingresa el nombre del producto: ");
    var nombre = Console.ReadLine().ToLower();

    Console.WriteLine("Ingresa el valor del producto: ");
    var valor = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa la cantidad del producto: ");
    var cantidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el nombre del vendedor: ");
    var vendedor = Console.ReadLine().ToLower();

    Console.WriteLine("Ingresa el nombre del comprador: ");
    var comprador = Console.ReadLine().ToLower();

    Console.WriteLine("Ingresa el tiempo de garantía: ");
    var garantia = Console.ReadLine();

    listaVentas.Add(new Venta(id, fecha, nombre, valor, cantidad, vendedor, comprador, garantia));

    Console.WriteLine("La venta fue registrada satisfactoriamente");
}

void MostrarVentas()
{
    foreach (Venta venta in listaVentas)
    {
        Console.WriteLine($"================= Factura ==================");
        Console.WriteLine($"ID:                     {venta.Id}");
        Console.WriteLine($"Fecha de Venta:         {venta.FechaDeVenta}");
        Console.WriteLine($"Vendedor:               {venta.Vendedor}");
        Console.WriteLine($"Comprador:              {venta.Comprador}");
        Console.WriteLine($"Valor del Producto:     {venta.ValorProducto:C}"); // :C formatea como moneda
        Console.WriteLine($"Cantidad:               {venta.CantidadProducto}");
        Console.WriteLine($"Tiempo de Garantía:     {venta.TiempoGarantia}");
        Console.WriteLine($"Total Facturado:        {venta.ValorProducto * venta.CantidadProducto:C} COP");
        Console.WriteLine("============================================\n");
    }

}

void PromedioVentas()
{
    Console.WriteLine("Escribe la fecha en el formato día/mes/año del promedio que requieres");
    var fecha = Convert.ToDateTime(Console.ReadLine());

    var listaTotales = listaVentas.Where(venta => venta.FechaDeVenta.Date == fecha.Date) // Filtramos las compras de la fecha ingresada por el usuario
    .Select(venta => venta.ValorProducto * venta.CantidadProducto) // Seleccionamos el valor * cantidad (total de cada venta)
    .ToList(); // Convertimos en lista para poder usar sus métodos

    // Si la lista, tiene 0 elementos es porque no hay ventas ese día

    if (listaTotales.Count == 0)
    {
        Console.WriteLine("El día ingresado no se encontraron ventas registradas.");
    }
    else  // sino, calculamos el promedio con el método Average
    {
        var promedio = listaTotales.Average();
        Console.WriteLine($"El promedio de compras de {fecha} fue de {promedio:C} COP");
    }

}

void MostrarVendedorDelMes()
{
    var empleadoMes = listaVentas.GroupBy(venta => venta.Vendedor) // Agrupamos por vendedor
    .OrderByDescending(total => total.Sum(venta => venta.CantidadProducto * venta.ValorProducto)) // sumamos las ventas que hizo
    .FirstOrDefault();
    Console.WriteLine(empleadoMes.Key);
}

void MostrarCompradorDelMes()
{
    var clienteMes = listaVentas.GroupBy(venta => venta.Comprador)
    .OrderByDescending(total => total.Sum(venta => venta.CantidadProducto * venta.ValorProducto))
    .FirstOrDefault();
    Console.WriteLine(clienteMes.Key);
}


void Menu()
{
    bool continuar = true; // Bandera para el menú
    while (continuar)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("          Menú de Gestión de Ventas         ");
        Console.WriteLine("===========================================");
        Console.WriteLine("0. Cerrar");
        Console.WriteLine("1. Ingresar venta");
        Console.WriteLine("2. Ver promedio ventas día específico");
        Console.WriteLine("3. Imprimir todas las facturas");
        Console.WriteLine("4. Empleado del mes");
        Console.WriteLine("5. Cliente del mes");
        Console.WriteLine("===========================================");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "0":
                Console.WriteLine("Hasta luego, vuelva pronto");
                continuar = false; // Rompemos el ciclo
                break;
            case "1":
                CrearVenta();
                PausarMenu();
                break;
            case "2":
                PromedioVentas();
                PausarMenu();
                break;
            case "3":
                MostrarVentas();
                PausarMenu();
                break;
            case "4":
                MostrarVendedorDelMes();
                PausarMenu();
                break;
            case "5":
                MostrarCompradorDelMes();
                PausarMenu();
                break;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo");
                break;
        }
    }
}

Menu();

void PausarMenu()
{
    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();
}

public class Venta
{
    public Guid Id { set; get; }
    public DateTime FechaDeVenta { set; get; }
    public string NombreProducto { set; get; }
    public double ValorProducto { set; get; }
    public int CantidadProducto { set; get; }
    public string Vendedor { set; get; }
    public string Comprador { set; get; }
    public string TiempoGarantia { set; get; }

    public Venta
    (
        Guid id,
        DateTime fechaDeVenta,
        string nombreProducto,
        double valorProducto,
        int cantidadProducto,
        string vendedor,
        string comprador,
        string tiempoGarantia
    )

    {
        Id = id;
        FechaDeVenta = fechaDeVenta;
        NombreProducto = nombreProducto;
        ValorProducto = valorProducto;
        CantidadProducto = cantidadProducto;
        Vendedor = vendedor;
        Comprador = comprador;
        TiempoGarantia = tiempoGarantia;
    }

}