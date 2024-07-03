Console.WriteLine("Hello, World!");

string userName = "Caro";
string lastname = "Bte";
string clan = "Dell";

Console.WriteLine($"El nombre del usuario es {userName}");
Console.WriteLine($"El apellido del usuario es {lastname}");
Console.WriteLine($"El clan del usuario es {clan}");

string saludo = $"Hola, mi nombre es {userName}"; //$ para concatenar

string saludo2 = @$"Hola, 
mi nombre es {userName},
mi apellido es {lastname} 
y estoy en el clan {clan}"; //@ para que coja el formato tal cual se ponga

Console.WriteLine(saludo);
Console.WriteLine(saludo2);

