var listaVentas = new List<Venta>();

void CrearVenta()
{
    var listaProductos = new List<Producto>();

    var id = Guid.NewGuid();
    var fecha = new DateTime();

    var productoId = Guid.NewGuid();
    Console.WriteLine("Ingresa el  del producto: ");
    var nombreProducto = Console.ReadLine();
    Console.WriteLine("Ingresa el valor del producto: ");
    var valorProducto = Convert.ToDouble(Console.ReadLine());
    
    var producto = new Producto(productoId, nombreProducto, valorProducto
    );

    Console.WriteLine("Ingresa la cantidad del producto: ");
    var cantidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el nombre del vendedor: ");
    var vendedor = Console.ReadLine();

    Console.WriteLine("Ingresa el nombre del comprador: ");
    var comprador = Console.ReadLine();

    Console.WriteLine("Ingresa el tiempo de garantía: ");
    var garantia = Console.ReadLine();

    listaVentas.Add(new Venta(id, fecha, producto, cantidad, vendedor, comprador, garantia));
}

public class Venta
{
    Guid Id { set; get; }
    DateTime FechaDeVenta { set; get; }

    Producto Producto { set; get; }
    int CantidadProducto { set; get; }
    string Vendedor { set; get; }
    string Comprador { set; get; }
    string TiempoGarantia { set; get; }

    public Venta(Guid id,
    DateTime fechaDeVenta,
    Producto producto,
    int cantidadProducto,
    string vendedor,
    string comprador,
    string tiempoGarantia)

    {
        Id = id;
        FechaDeVenta = fechaDeVenta;
        Producto = producto;
        CantidadProducto = cantidadProducto;
        Vendedor = vendedor;
        Comprador = comprador;
        TiempoGarantia = tiempoGarantia;
    }

}

public class Producto
{
    Guid Id { set; get; }
    string Nombre { set; get; }
    double Valor { set; get; }

    public Producto(Guid id, string nombre, double valor)
    {
        Id = id;
        Nombre = nombre;
        Valor = valor;
    }
}


