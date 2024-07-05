using System.Numerics;

public class Product
{
    // Creamos la plantilla de un producto
    // Keys que va a tener cada producto:
    public string? Name { set; get; } // Name va a ser un string, ? para que pueda ser NULL
    public int Quantity { set; get; } // Quantity va a ser un entero 
    public double Price { set; get; } // Price es un double porque es para cosas financieras

    // Definir el objeto de producto
    public Product(string name, int quantity, double price) // values que recibe cada key
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}

public class Program
{
    static List<Product> Products = new List<Product>();
    public static void Main()
    {
        Products.Add(new Product("papa", 10, 10.500));
        Products.Add(new Product("tomate", 1, 200));
        Products.Add(new Product("cebolla", 1, 1000));


        bool flag = true; // bandera para el menú
        while (flag)
        {
            Console.WriteLine(" _______________________________________________________________________________________________ ");
            Console.WriteLine("|                                        INVENTARIO                                             |");
            Console.WriteLine("|_______________________________________________________________________________________________|");
            Console.WriteLine("|                                    1. Agregar producto                                        |");
            Console.WriteLine("|                                    2. Modificar producto                                      |");
            Console.WriteLine("|                                    3. Eliminar producto                                       |");
            Console.WriteLine("|                                    4. Listar productos                                        |");
            Console.WriteLine("|                                    5. Salir                                                   |");
            Console.WriteLine("|_______________________________________________________________________________________________|");
            Console.Write("INGRESE OPCION: ");

            int? option = Convert.ToInt32(Console.ReadLine()); // solicitamos al usuario la opción

            switch (option) // según la opción que ingrese...

            {
                case 1:
                    AddProduct();
                    PrintProducts();
                    break;
                case 2:
                    UpdateProduct();
                    PrintProducts();
                    break;
                case 3:
                    DeleteProduct();
                    PrintProducts();
                    break;
                case 4:
                    PrintProducts();
                    break;
                case 5:
                    Console.WriteLine("Adiós, vuelva pronto...");
                    flag = false; // Rompemos el ciclo while para que finalice el programa
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente nuevamente");
                    break;
            }
        }
    }

    static void PrintProducts()
    {
        double total = 0;

        foreach (Product product in Products)
        {
            Console.WriteLine($"Producto: {product.Name}  | Precio unitario: {product.Price:C}  |  Cantidad: {product.Quantity}  |  Total: {(product.Quantity * product.Price):C}");
            total += product.Quantity * product.Price;
        }

        Console.WriteLine($"Total: {total:C}");
    }

    static void AddProduct()
    {

        Console.WriteLine("Escribe el nombre del producto a ingresar");
        string? name = Console.ReadLine().ToLower();

        Console.WriteLine($"Escribe la cantidad del {name}");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Escribe el precio unitario del {name}");
        double price = Convert.ToDouble(Console.ReadLine());

        if (!string.IsNullOrWhiteSpace(name))
        {
            Products.Add(new Product(name, quantity, price));
            Console.WriteLine($"{name} fue agregado satisfactoriamente!");
        }
    }

    static void DeleteProduct()
    {
        Console.WriteLine("Escribe el nombre del producto a eliminar");
        string? name = Console.ReadLine().ToLower();

        Product? productFinded = Products.Find(product => product.Name == name);

        if (productFinded != null)
        {
            Console.WriteLine($"¿Está seguro que desea eliminar {productFinded.Name}?");
            string? confirmacion = Console.ReadLine();
            if (!string.IsNullOrEmpty(confirmacion) && confirmacion.ToLower() == "si")
            {
                Products.Remove(productFinded);
                Console.WriteLine($"{productFinded.Name} fue eliminado satisfactoriamente");
            } 
        }
    }

    static void UpdateProduct()
    {
        Console.WriteLine("Escribe el nombre del producto a editar");
        string? name = Console.ReadLine().ToLower();

        Console.WriteLine($"Escribe la nueva cantidad de {name}");
        int newQuantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Escribe el nuevo precio unitario de {name}");
        double newPrice = Convert.ToDouble(Console.ReadLine());

        /*         foreach (Product product in Products)
        {
            if (product.Name == name)
            {
                product.Price = newPrice;
                product.Quantity = newQuantity;
            }
        } */

        Product? productFinded = Products.Find(product => product.Name == name);

        if (productFinded != null)
        {
            productFinded.Quantity = newQuantity;
            productFinded.Price = newPrice;
            Console.WriteLine($"{productFinded.Name} fue editado satisfactoriamente");
        }
    }

}


