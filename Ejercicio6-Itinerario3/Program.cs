// See https://aka.ms/new-console-template for more information
using Ejercicio6_Itinerario3;

Console.WriteLine("Hello, World!");

Calculadora calculadora1 = new Calculadora();
Calculadora calculadora2 = new Calculadora(10);

Console.WriteLine("Suma int: " + calculadora1.Sumar(2, 3));
Console.WriteLine("Suma double: " + calculadora1.Sumar(2.5, 3.5));

Console.WriteLine("Valor inicial Calculadora 2: " + calculadora2.valorInicial);