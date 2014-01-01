using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_get_and_set
{
    class Persona
    {
        //Declaramos los atributos 
        private string Nombre;
        private string Apellido;
        private int Edad;
        /*Método constructor de la clase persona que recibe los parámetros el 
            nombre apellido edad  */
        public Persona(string Nombre, string Apellido, int Edad)
        {
            //Asignamos los parámetros a los atributos
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
        }
        // Una propiedad de lectura y escritura de tipo cadena
        public string PerNombre
        {
            //método get sirve para obtener los datos
            get
            {
                return Nombre;
            }
            //Método set para asignar datos o modificar
            set
            {
                Nombre = value;
            }
        }
        // Una propiedad de lectura y escritura de tipo cadena
        public string PerApellido
        {
            //método get sirve para obtener los datos
            get
            {
                return Apellido;
            }
            //Método set para asignar datos o modificar
            set
            {
                Apellido = value;
            }
        }
        // Una propiedad de lectura  de tipo int
        public int PerEdad
        {
            //método get sirve para obtener los datos
            get
            {
                return Edad;
            }
        }
    }
}
