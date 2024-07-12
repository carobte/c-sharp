var listaVentas = new List<Venta>();

void CrearVenta()
{
    var id = Guid.NewGuid();
    var fecha = DateTime.Now;

    Console.WriteLine("Ingresa el nombre del producto: ");
    var nombre = Console.ReadLine();

    Console.WriteLine("Ingresa el valor del producto: ");
    var valor = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa la cantidad del producto: ");
    var cantidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el nombre del vendedor: ");
    var vendedor = Console.ReadLine();

    Console.WriteLine("Ingresa el nombre del comprador: ");
    var comprador = Console.ReadLine();

    Console.WriteLine("Ingresa el tiempo de garantía: ");
    var garantia = Console.ReadLine();

    listaVentas.Add(new Venta(id, fecha, nombre, valor, cantidad, vendedor, comprador, garantia));
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
        Console.WriteLine("===========================================\n");
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
   if(listaTotales.Count == 0)
    {
       Console.WriteLine("El día ingresado no se encontraron ventas registradas.");
    } else  // sino, calculamos el promedio con el método Average
    {
        var promedio = listaTotales.Average();
        Console.WriteLine($"El promedio de compras de {fecha} fue de {promedio:C} COP");
    }  

}


void Menu()
{
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("          Menú de Gestión de Ventas         ");
        Console.WriteLine("===========================================");
        Console.WriteLine("1 Ingresar venta");
        Console.WriteLine("2 Ver promedio ventas día específico");
        Console.WriteLine("3 Imprimir todas las facturas");
        Console.WriteLine("4 Cerrar");
        Console.WriteLine("===========================================");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                CrearVenta();
                break;
            case "2":
                PromedioVentas();
                break;
            case "3":
                MostrarVentas();
                break;
            case "4":
                Console.WriteLine("Hasta luego, vuelva pronto");
                continuar = false;
                break;
            default:

                break;
        }
    }
}

Menu();

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