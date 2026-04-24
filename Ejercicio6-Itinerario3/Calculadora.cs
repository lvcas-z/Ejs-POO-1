using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Itinerario3
{
    internal class Calculadora
    {

        public int valorInicial { get; set; }

        public Calculadora()
        {
            valorInicial = 0;
        }

        // sobrecarga de constructor
        public Calculadora(int valor)
        {
            valorInicial = valor;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // metodo sobrecargado
        public double Sumar(double a, double b)
        {
            return a + b;
        }
    

    }
}
