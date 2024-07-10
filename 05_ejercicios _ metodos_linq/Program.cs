/*
// Métodos LINQ

// Método FirstOrDefault()
var numbers = new List<int>(){1, 2, 3, 4, 5, 4, 6, 5, 4,7,8,9};
var first = numbers.IndexOf(numbers.FirstOrDefault(num => num == 4));
Console.WriteLine(first); //si no encuentra el numero que se le paso por parametro, devuelve un 0

// Método Max() -> no necesita parametro 
var max = numbers.Max(num => num);
Console.WriteLine(max);

// Método Min() -> no necesita parametro 
var min = numbers.Min(num => num);
Console.WriteLine(min);

// Average
var notas = new List<double>(){1.2, 3.4,1.2};
var promedio = notas.Average();
Console.WriteLine(Math.Round(promedio, 2));

// Where

var numeroMayor = numbers.Where(num => num >4).ToList();
foreach (var num in numeroMayor)
{
    Console.WriteLine($"Los numeros mayores a 6 son: {num}");
}*/

// Ejercicios

// 1. Filtra los números mayores a 10 en una lista de enteros.

var enteros = new List<int> { 1, 2, 3, 40, 5, 60, 70, 11, 12, 13, 14, 15, 3, 40, 5, 70, 11 };
var mayores10 = enteros.Where(num => num > 10);

Console.WriteLine($"1. Números mayores a 10: ");

foreach (var mayor in mayores10)
{
    Console.WriteLine(mayor);
}

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.

var cuadrados = enteros.Select(num => Math.Pow(num, 2));

Console.WriteLine($"2. Cuadrados: ");

foreach (var cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}

// 3. Ordena alfabéticamente una lista de nombres.

var nombres = new List<string>() { "Caro", "Cami C", "Cami B", "Santi", "Pablo", "Daniel", "Val" };
var nombresOrdenados = nombres.OrderBy(nombre => nombre);

Console.WriteLine($"3. Nombres alfabéticamente: ");

foreach (var nombre in nombresOrdenados)
{
    Console.WriteLine(nombre);
}

// 4. Ordena una lista de precios de mayor a menor.

var precios = new List<double>() { 4.500, 5000, 3.500, 10000 };
var preciosOrdenados = precios.OrderByDescending(precio => precio);

Console.WriteLine($"4. Precios mayor a menor: ");

foreach (var precio in preciosOrdenados)
{
    Console.WriteLine(precio);
}


// 5. Encuentra el primer número par en una lista de enteros.

var primerPar = enteros.First(num => num % 2 == 0);
Console.WriteLine($"5. Primer par: {primerPar}");

// 6. Encuentra el último nombre en una lista de nombres.

var ultimoNombre = nombres.Last();
Console.WriteLine($"6. Ultimo nombre: {ultimoNombre}");

// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.

var primerNegativo = enteros.FirstOrDefault(num => num < 0);
Console.WriteLine($"7. Primer negativo: {primerNegativo}");

// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno.

var ultimoNumeroMayor = enteros.LastOrDefault(num => num > 50);
Console.WriteLine($"8. Último número mayor a 50: {ultimoNumeroMayor}");

// 9. Verifica si algún elemento en una lista de booleanos es verdadero.

var booleanos = new List<bool>() { false, true, false };
var verdadero = booleanos.Any(booleano => booleano == true);

Console.WriteLine($"9. Algún verdadero?: {verdadero}");

// 10. Verifica si todos los elementos en una lista de números son mayores a 0.

var mayores = enteros.All(num => num > 10);
Console.WriteLine($"10. Todos son mayores de 10?: {mayores}");

// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".

var palabras = new List<string> { "LINQ", "C#", "Javascript", "Python" };
var contieneLINQ = palabras.Contains("LINQ");

Console.WriteLine($"11.Contiene LINQ?: {contieneLINQ}");

// 12. Cuenta cuántos números pares hay en una lista de enteros.

var pares = enteros.Count(num => num % 2 == 0);
Console.WriteLine($"12. Pares: {pares}");

// 13. Calcula la suma de los elementos en una lista de precios.

var total = precios.Sum();
Console.WriteLine($"13. Suma precios: {total}");

// 14. Calcula el promedio de una lista de edades.

var edades = new List<int>() { 18, 20, 35, 21, 23 };
var promedio = edades.Average();

// 15. Encuentra el número mínimo en una lista de temperaturas.

var temperaturas = new List<int>() { 30, -10, 100, 25, -30 };
var temperaturaMenor = temperaturas.Min();

Console.WriteLine($"15. La menor temperatura es: {temperaturaMenor}");

// 16. Encuentra el número máximo en una lista de alturas.

var alturas = new List<double>() { 1.56, 1.78, 1.90 };
var alturaMayor = alturas.Max();

Console.WriteLine($"16. La altura mayor es {alturaMayor}");

// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.

var puntuaciones = new List<double>() { 4.5, 3.0, 6.0, 8.7, 2.0, 2.5, 5.5 };
var primerasPuntuaciones = puntuaciones.Take(5);

Console.WriteLine($"17. Primeras 5 puntuaciones: ");

foreach (var puntuacion in primerasPuntuaciones)
{
    Console.WriteLine(puntuacion);
}

// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.

var nombresSkip = nombres.Skip(3);

Console.WriteLine($"18. Nombres sin los primeros 3: ");


foreach (var nombre in nombresSkip)
{
 Console.WriteLine(nombre);
}

// 19. Elimina los elementos duplicados en una lista de números.

var numerosUnicos = enteros.Distinct();

Console.WriteLine($"19. Números únicos: ");

foreach (var num in numerosUnicos)
{
    Console.WriteLine(num);
}


// 20. Convierte una lista de palabras en un array.


// 21. Convierte una lista de números en un array.


// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.


// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.


// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.


// 25. Obtén los nombres más largos en una lista de nombres.


// 26. Encuentra el primer número mayor a 100 en una lista de precios.


// 27. Encuentra el último día del mes en una lista de fechas.


// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por defecto si no hay ninguno.


// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay ninguno.


// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.


// 31. Verifica si todas las edades en una lista son mayores de 18.


// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".


// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.


// 34. Calcula la suma de los números positivos en una lista de enteros.


// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.


// 36. Encuentra la temperatura mínima en una lista de temperaturas.


// 37. Encuentra la altura máxima en una lista de alturas.


// 38. Obtén los primeros 10 elementos de una lista de productos.


// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.


// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.



