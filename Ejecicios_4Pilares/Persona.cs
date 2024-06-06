using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicios_4Pilares
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }

        
        public Persona(string _nombre, int _edad, string _direccion)
        {
            nombre = _nombre;
            edad = _edad;
            direccion= _direccion;
        }

        //Se crea un constructor de la Clase Persona
        public Persona(string _nombre)
        {
            nombre = _nombre;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(nombre + " es la persona del cual les hablaba, tiene " + edad + " y vive en la direccion: " + direccion);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Démosles la bienvenida. :)");
            Console.WriteLine("--------------------------");
        }

        public void Nacimiento()
        {
            int anioNac = 0;
            int anioActual = DateTime.Now.Year;
            anioNac = anioActual - edad;

            Console.WriteLine("-> "+nombre + " nació en el año " + anioNac + ".");
            Console.WriteLine("");
        }
    }
}
