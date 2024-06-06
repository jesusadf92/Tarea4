using Ejecicios_4Pilares;
using System;

namespace Ejecicios_4Pilares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1=new Persona("Jesus De La Paz", 32, "Calle Principal Salome Ureña");
            persona1.Mostrar();
            Console.WriteLine();
            persona1.Nacimiento();
            
            Empleado empleado1=new Empleado("Juancito","Administrador de sistemas", 70000.78);
            empleado1.Mostrar();
        }
    }
}
