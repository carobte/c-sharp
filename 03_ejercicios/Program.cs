// Ejercicios.

// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"{i + 1}");
}

// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números pares desde 1 hasta ese número usando un ciclo for.

Console.Write("Escribe un número positivo (+): ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Pares: ");

for (int i = 1; i <= numero; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}

// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.

Console.WriteLine($"Tabla de multiplicar de {numero}");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que adivine correctamente usando un ciclo do-while.

Random random = new Random();

int numAleatorio = random.Next(1, 101);
Console.WriteLine($"Num aleatorio: {numAleatorio}");
bool flag = true;

do
{
    Console.WriteLine("Ingresa un número entre 1 y 100");
    int numIngresado = int.Parse(Console.ReadLine());

    if (numIngresado > numAleatorio)
    {
        Console.WriteLine($"El número que ingresaste ({numIngresado}) es demasiado alto, intenta de nuevo");
    }
    else if (numIngresado < numAleatorio)
    {
        Console.WriteLine($"El número que ingresaste ({numIngresado}) es demasiado bajo, intenta de nuevo");

    }
    else
    {
        Console.WriteLine("Felicitaciones. ¡Adivinaste el número!");
        flag = false; // Rompe el ciclo
    }

} while (flag);

// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números impares desde ese número hasta 1 usando un ciclo while.

Console.Write("Escribe otro número positivo (+): ");
int numero2 = int.Parse(Console.ReadLine());

Console.Write("Impares: ");

int iterador = 1;

while (iterador <= numero2)
{
    if (iterador % 2 != 0)
    {
        Console.WriteLine($"{iterador}");
    }
    iterador++;
}

// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta usando un ciclo while.

string contrasena = "";

while (contrasena != "secreta")

{
    Console.WriteLine("Ingresa la contraseña: ");
    contrasena = Console.ReadLine();
}


// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la secuencia de Fibonacci hasta ese número usando un ciclo for.


// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el número es primo o no usando un ciclo for.

Console.WriteLine("Escribe un número positivo (+): ");
int numero3;

if (int.TryParse(Console.ReadLine(), out numero3)) // si parsea bien, entra en numero3
{
    for (int i = 1; i < numero3; i++)
    {
        if (numero % i == 0)
        {
            Console.WriteLine($"El {numero3} es primo");
        }
    }

}

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la palabra en una línea separada usando un ciclo foreach. 

Console.WriteLine("Escribe una palabra: ");
string palabra = Console.ReadLine();

foreach (char letra in palabra)
{
    Console.WriteLine($"{letra}");
}


// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma de todos los números desde 1 hasta ese número usando un ciclo for.

Console.WriteLine("Escribe otro número positivo(+): ");
int numero4 = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= numero4; i++)
{
    suma += i;
}
    Console.WriteLine($"{suma}");