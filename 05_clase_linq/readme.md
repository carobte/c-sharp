 # LINQ

 LINQ (Language Integrated Query) en C# proporciona métodos que permiten realizar consultas sobre datos de manera similar a SQL, pero dentro del código C#. Aquí tienes una lista de métodos importantes de LINQ en C#:
1. **Métodos de filtrado:**
   - `Where`: Filtra una secuencia de acuerdo a un predicado.
   - `OfType`: Filtra elementos de una secuencia según un tipo específico.
2. **Métodos de proyección:**
   - `Select`: Proyecta cada elemento de una secuencia en un nuevo formulario.
   - `SelectMany`: Proyecta secuencias anidadas en una única secuencia plana.
3. **Métodos de ordenación:**
   - `OrderBy`, `OrderByDescending`: Ordena una secuencia en orden ascendente o descendente según una clave.
   - `ThenBy`, `ThenByDescending`: Utilizado para ordenar secundariamente después de una ordenación primaria.
4. **Métodos de agrupamiento:**
   - `GroupBy`: Agrupa elementos de una secuencia según una clave.
5. **Métodos de unión:**
   - `Join`: Combina dos secuencias basándose en una clave compartida entre ellas.
   - `GroupJoin`: Realiza una combinación entre dos secuencias, agrupando los resultados.
6. **Métodos de generación de secuencias:**
   - `Range`: Genera una secuencia de números enteros dentro de un rango especificado.
   - `Repeat`: Genera una secuencia que contiene un elemento repetido un número específico de veces.
7. **Métodos de combinación y manipulación:**
   - `Concat`: Combina dos secuencias en una sola.
   - `Zip`: Combina dos secuencias en una secuencia única utilizando una función de combinación.
8. **Métodos de elementos únicos:**
   - `Distinct`: Elimina duplicados de una secuencia.
   - `Union`: Combina dos secuencias eliminando duplicados.
9. **Métodos de agregación:**
   - `Count`: Cuenta el número de elementos en una secuencia.
   - `Sum`, `Average`, `Min`, `Max`: Realizan operaciones de agregación en una secuencia numérica.
10. **Métodos de partición:**
    - `Take`: Devuelve un número especificado de elementos desde el inicio de una secuencia.
    - `Skip`: Omite un número especificado de elementos desde el inicio de una secuencia.
Estos métodos permiten manipular y consultar datos de manera eficiente y expresiva en C# utilizando LINQ, mejorando la legibilidad y mantenibilidad del código.
Nuevo
07:52
Por supuesto, aquí te dejo ejemplos básicos de cada uno de los métodos mencionados de LINQ en C#. Todos estos ejemplos suponen que trabajamos con una colección de objetos `Person` con propiedades como `Name`, `Age`, `City`, etc.
### Métodos de filtrado:
1. **Where**
```csharp
var adults = people.Where(p => p.Age >= 18);
```
2. **OfType**
```csharp
var numbers = new object[] { 1, "two", 3, "four", 5 };
var ints = numbers.OfType<int>();
```
### Métodos de proyección:
3. **Select**
```csharp
var names = people.Select(p => p.Name);
```
4. **SelectMany**
```csharp
var allHobbies = people.SelectMany(p => p.Hobbies);
```
### Métodos de ordenación:
5. **OrderBy / OrderByDescending**
```csharp
var sortedByName = people.OrderBy(p => p.Name);
var sortedByAgeDescending = people.OrderByDescending(p => p.Age);
```
6. **ThenBy / ThenByDescending**
```csharp
var sortedByNameThenByAge = people.OrderBy(p => p.Name).ThenBy(p => p.Age);
```
### Métodos de agrupamiento:
7. **GroupBy**
```csharp
var groupedByCity = people.GroupBy(p => p.City);
```
### Métodos de unión:
8. **Join**
```csharp
var result = people.Join(
    pets,
    person => person.Id,
    pet => pet.OwnerId,
    (person, pet) => new
    {
        PersonName = person.Name,
        PetName = pet.Name
    }
);
```
9. **GroupJoin**
```csharp
var result = people.GroupJoin(
    pets,
    person => person.Id,
    pet => pet.OwnerId,
    (person, petsOfPerson) => new
    {
        PersonName = person.Name,
        Pets = petsOfPerson.Select(p => p.Name).ToList()
    }
);
```
### Métodos de generación de secuencias:
10. **Range**
```csharp
var numbers = Enumerable.Range(1, 10);
```
11. **Repeat**
```csharp
var sequence = Enumerable.Repeat("Hello", 3);
```
### Métodos de combinación y manipulación:
12. **Concat**
```csharp
var combined = sequence1.Concat(sequence2);
```
13. **Zip**
```csharp
var zipped = sequence1.Zip(sequence2, (item1, item2) => item1 + "-" + item2);
```
### Métodos de elementos únicos:
14. **Distinct**
```csharp
var uniqueCities = people.Select(p => p.City).Distinct();
```
15. **Union**
```csharp
var allUniqueNames = names1.Union(names2);
```
### Métodos de agregación:
16. **Count**
```csharp
var count = people.Count();
```
17. **Sum / Average / Min / Max**
```csharp
var totalAge = people.Sum(p => p.Age);
var averageAge = people.Average(p => p.Age);
var youngest = people.Min(p => p.Age);
var oldest = people.Max(p => p.Age);
```
### Métodos de partición:
18. **Take**
```csharp
var firstThree = numbers.Take(3);
```
19. **Skip**
```csharp
var skipFirstThree = numbers.Skip(3);
```
Estos ejemplos te proporcionan una idea de cómo utilizar los diferentes métodos de LINQ en C# para realizar diversas operaciones sobre colecciones de datos de manera funcional y expresiva.









