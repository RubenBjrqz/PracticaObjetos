using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto es el espacio de memoria o ram que ocupa
            //Clase es un modelo que define un conjunto de variables
            //Public es un modificador de acceso

            Persona persona1 = new Persona();
            persona1.nombre = "José";
            persona1.apellidos = "José";
            persona1.edad = 70;
            persona1.altura = 1.5f;
            Console.WriteLine(persona1.nombre + " " + persona1.apellidos + " tiene " + persona1.edad + " Años");

            persona1.cumplirAños();
            Console.WriteLine("Ahora " + persona1.nombre + " tiene " + persona1.edad + " Años");

            Console.WriteLine(persona1.nombre + " mide: " + persona1.altura);
            persona1.crecer(0.12f);
            Console.WriteLine(persona1.nombre + " ahora mide: " + persona1.altura);

            Console.ReadLine();
        }
    }
}
