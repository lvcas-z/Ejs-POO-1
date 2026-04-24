using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Itinerario3
{
    internal class Persona
    {

        private string password;
        private DateTime fechaNacimiento;
        private string[] telefonos = new string[2];

        private string dato;

        // lectura-escritura
        public string Nombre { get; set; }

        // auto
        public string Apellido { get; set; }

        // solo lectura
        public int Edad
        {
            get { return DateTime.Now.Year - fechaNacimiento.Year; }
        }

        // solo escritura
        public string Password
        {
            set { password = value; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
        }

        // propiedad con argumentos
        public string this[int i]
        {
            get { return telefonos[i]; }
            set { telefonos[i] = value; }
        }

    }
}
