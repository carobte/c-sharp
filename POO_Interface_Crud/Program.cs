
using POO_Interface_Crud.Models;

var listaCoders = new List<Coder>();

var coder = Coder.GetData();
var coder2 = Coder.GetData();

coder.Create(listaCoders, coder);
coder2.Create(listaCoders, coder2);

coder.Read(listaCoders);

// coder.Update(listaCoders, new Guid(""));

// Crear storage(abstracta), lista(static), que sea la que usa la interfaz y las operaciones de CRUD