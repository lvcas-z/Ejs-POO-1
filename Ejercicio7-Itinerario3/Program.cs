// See https://aka.ms/new-console-template for more information
using Ejercicio7_Itinerario3;

Console.WriteLine("Hello, World!");
Persona p = new Persona();

p.Nombre = "Lucas";
p.Apellido = "Zelaya";
p.Password = "1234";
p.FechaNacimiento = new DateTime(2002, 1, 4);

// agrego telefonos
p[0] = "123456";
p[1] = "789101";

Console.WriteLine("Nombre: " + p.Nombre);
Console.WriteLine("Edad: " + p.Edad);
Console.WriteLine("Teléfono 1: " + p[0]);
Console.WriteLine("Teléfono 2: " + p[1]);