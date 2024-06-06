using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicios_4Pilares
{
    //Empleado
    public class Empleado:Persona
    {

        string puesto { get; set; }
        double salario { get; set; }

        public Empleado(string _nombre, string _puesto, double _salario)
            : base (_nombre)
        {
            puesto = _puesto;
            salario = _salario;
        }     
        public override void Mostrar()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("***INFORMACION DEL EMPLEADO***");
            Console.WriteLine("************************************");
            Console.WriteLine("Nombre del empleado: "+ nombre);
            Console.WriteLine("Puesto de trabajo: "+ puesto);
            Console.WriteLine("Salario mensual:   "+ salario);
            Console.WriteLine("************************************");
        }


    }
}
