var listaVentas = new List<Venta>();

void CrearVenta()
{
    var id = Guid.NewGuid();
    var fecha = new DateTime();

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

}

public class Venta
{
    Guid Id { set; get; }
    DateTime FechaDeVenta { set; get; }
    string NombreProducto { set; get; }
    double ValorProducto { set; get; }
    int CantidadProducto { set; get; }
    string Vendedor { set; get; }
    string Comprador { set; get; }
    string TiempoGarantia { set; get; }

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
