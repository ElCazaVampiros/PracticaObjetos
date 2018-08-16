using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Andres Sanchez Gomez";
            contacto1.TelefonoCasa = "(666) 911 - 523";
            contacto1.Direccion = "the bronx";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de casa: " + contacto1.TelefonoCasa);

            Contacto contacto2 = new Contacto("Neto");
            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto contacto3 =
                new Contacto("Pancho Encinas", "64417457", "4126894", "el deefe", "equisde@hotmail.com");
            Console.WriteLine("Contacto 3");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("TelefonoCasa: " + contacto3.TelefonoCasa);
            Console.WriteLine("Direccion: " + contacto3.CorreoElectronico);

            Console.ReadLine();
        }
    }
}