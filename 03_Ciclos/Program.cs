// Ciclo for 
/* determinamos número de iteraciones
 usado para recorrer listas, arrays */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hola mundo, iteración {i}");

}

// Ciclo foreach
/* Desde primero hasta último elementos de listas */

string[] nombres = { "Juan", "Pedro", "Ana" }; //array

// listas
List<string> list = new List<string>();
list.Add("Luis"); // añadir nombres a lista

foreach (string nombre in nombres)
{
    Console.WriteLine($"Hola, {nombre}");
}


// Ciclo while
/* No sabemos cuántas iteraciones, condición */

bool flag = true;

while (flag)
{
    Console.WriteLine("Hola mundo");
    Console.WriteLine("¿Deseas repetir el mensaje?");
    string? respuesta = Console.ReadLine(); // ? es para no interrumpir flujo si repuesta queda null
    if (respuesta?.ToLower() == "no")
    {
        flag = false; // se puede poner break o return para romper el ciclo
    }
}
