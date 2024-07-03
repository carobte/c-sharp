// Condicionales 

Console.Write("Ingresa tu edad por favor ");

byte edad = Convert.ToByte(Console.ReadLine()); // byte: espacio de memoria
// Convert to byte: convertimos el string de la consola para byte.

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else if (edad >= 12 && edad < 18)
{
    Console.WriteLine("Eres un adolescente");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

// Para declarar constante, palabra const, nombre en mayus sostenida, deben ser inicializadas una vez declardas. 
// const byte DIA = 5;

Console.Write("Ingresa un número del 1 al 7 ");

byte numero = Convert.ToByte(Console.Read());

switch (numero)
{
    case 1:
        Console.WriteLine("Elegiste el lunes");
        break;
    case 2:
        Console.WriteLine("Elegiste el martes");
        break;
    case 3:
        Console.WriteLine("Elegiste el miércoles");
        break;
    case 4:
        Console.WriteLine("Elegiste el jueves");
        break;
    case 5:
        Console.WriteLine("Elegiste el viernes");
        break;
    case 6:
        Console.WriteLine("Elegiste el sábado");
        break;
    case 7:
        Console.WriteLine("Elegiste el domingo");
        break;
    default:
        Console.WriteLine("Elegiste una opción incorrecta");
        break;
}