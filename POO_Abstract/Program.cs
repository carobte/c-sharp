using POO_Abstract.Models;

// clase padre
// var objetoPadre = new Animal(1, "Milu", "perro");

// clase hija
var objetoHijo = new Perro(2, "Orion", "perro", true);

/* 

Se utiliza abstract para crear un molde o plantilla.
No puede ser instanciado directamente. Con un método o 
propiedad abstract, la clase tiene que ser abstract. 
En métodos solo pone el nombre del método y obligatoriamente 
la clase hija tiene que utilizar el método. 

- Las clases static no se dejan heredar. Se utilizan para 
crear características o configuraciones generales para 
que sean utilizadas por cualquier sección del sistema. Si
la clase es static, todo es static

- Las clases al heredar, pueden utilizar propiedades y
métodos. Sin embargo, si son abstract sí o sí están
obligada a usarlos, no importa si están vacíos. 
Pueden ser heredadas. La clase puede ser abstract pero no
obliga a sus propiedades y métodos a serlo.

*/

// Ejemplos:

// Static 

Console.WriteLine("Escribe un número: ");
var num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe otro número: ");
var num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Suma: {Calculadora.Sumar(num1, num2)}");
Console.WriteLine($"Suma: {Calculadora.Restar(num1, num2)}");
Console.WriteLine($"Suma: {Calculadora.Multiplicar(num1, num2)}");
Console.WriteLine($"Suma: {Calculadora.Dividir(num1, num2)}");

// Abstract 

var coder1 = new Coder("Caro", "Bte", "Dell");
coder1.Saludar();
