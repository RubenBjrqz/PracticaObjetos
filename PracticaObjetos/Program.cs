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
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Benito Camela";
            contacto1.TelefonoCasa = "(644) 333 - 5324";
            contacto1.Direccion = "Demiano 523 ";


            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de casa: " + contacto1.TelefonoCasa);

            Contacto contacto2 = new Contacto("Batman");
            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto Contacto3 = new Contacto("Doña Mary", "34645435", "4134134", "Calle Chihuahua", "Ladoñamary@gmail.com");

            Console.WriteLine("Contacto 3");
            Console.WriteLine("Nombre:" + Contacto3.Nombre);
            Console.WriteLine("Celular: " + Contacto3.TelefonoCelular);
            Console.WriteLine("Telefono Casa: " + Contacto3.TelefonoCasa);
            Console.WriteLine("Direccion: " + Contacto3.Direccion);
            Console.WriteLine("E-mail: " + Contacto3.CorreoElectronico);

            Console.ReadLine();

        }
    }
}
