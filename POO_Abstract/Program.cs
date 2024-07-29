using POO_Abstract.Models;

// clase padre
// var objetoPadre = new Animal(1, "Milu", "perro");

// clase hija
var objetoHijo = new Perro(2, "Orion", "perro", true);

/* Se utiliza abstract para crear un molde o plantilla.
No puede ser utilizado directamente. Con un método o 
propiedad abstract, la clase tiene que ser abstract. 
En métodos solo se puede poner el nombre del método y 
obligatoriamente la clase hija tiene que utilizar el método. 
*/
