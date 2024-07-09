/* Console.Clear();
Console.WriteLine("Hello, World!");

// Variables:

- Cadenas (string, char)
- Numeros (int, float, double, byte, long, decimal, unit)
- Booleanos (true, false)


char nombre = 'J';
Console.WriteLine(nombre.GetType().Name);

// Array, tipado

var frutasArray = new string[]{
    "banano",
    "pera",
    "sandía",
};

frutasArray[1] = "fresa"; // sobreescribir valor del indice 1

Console.WriteLine(frutasArray.GetType().Name);
Console.WriteLine(frutasArray[1]);

// Array de números
var numerosArray = new byte[] { 9, 10, 7, 8, 3, 4, 6, 1, 5, 2 };

// Recorrer el array

foreach (var numero in numerosArray)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}

// -------------------------------------------------------------

// Listas

// Lista de frutas

var frutasList = new List<string>(){
    "manzana",
    "naranja",
    "uva"
};

// Lista de números

var numerosList = new List<byte> { 9, 10, 7, 8, 4, 3, 6, 1, 5, 2 };

// Recorrer lista

// Lista vacía para números vacíos

var numerosParesList = new List<byte>();

// Programación imperativa -> paso a paso, más manual

foreach (var numero in numerosList)
{
    if (numero % 2 == 0)
    {
        numerosParesList.Add(numero);
    }
}


foreach (var numeroPar in numerosParesList)
{
    Console.WriteLine(numeroPar);
}

// -------------------------------------------------------------

// Linq -> Language Integrated Query

// Programación declarativa -> con métodos

// Números pares:

var numerosParesList2 = numerosArray.Where(num => num % 2 == 0).ToList();

// Números duplicados:

var numerosDuplicadosList = numerosArray.Select(num => num * 2).ToList();

// Números ordenados:

// OrderBy -> por defecto trae por Ascendente.

Console.WriteLine("Ordenados:");

var numerosListAsc = numerosArray.OrderBy(num => num).ToList();

foreach (var numero in numerosListAsc)
{
    Console.WriteLine(numero);
}

var numerosListDesc = numerosArray.OrderByDescending(num => num).ToList();

foreach (var numero in numerosListDesc)
{
    Console.WriteLine(numero);
}
 */

// Ejemplo métodos linq
public class Program{

    Persona persona = new("Cami", "Barreneche", 28, true);
    public static void Main(string[] args){

    }
}

public class Persona
{
    public string? Nombre { set; get; }
    public string? Apellido { set; get; }
    public int Edad { set; get; }
    public bool Activo { set; get; }

    public Persona(string? nombre, string? apellido, int edad, bool activo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Activo = activo;
    }
}

