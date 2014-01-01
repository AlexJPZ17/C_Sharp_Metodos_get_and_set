using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_get_and_set
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamamos la clase persona y hacemos un objeto llamado per
            Persona per = new Persona("Alex", "Pagoada", 29);
            per.PerNombre = "Joel";
            Console.WriteLine("Su nombre es: " + per.PerNombre);
            Console.WriteLine("Su apellido es: " + per.PerApellido);
            Console.WriteLine("Su edad es: " + per.PerEdad);
            Console.ReadLine();
        }
    }
}
