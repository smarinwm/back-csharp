using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClasePersona
{
    internal class Program
    {
        class Persona
        {
            private string nombre;
            private int edad;

            public void instanciar()
            {
                Console.Write("Ingrese el nombre:");
                nombre = Console.ReadLine();
                string linea;
                Console.Write("Ingrese la edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
            }

            public void imprimir()
            {
                Console.Write("Nombre:");
                Console.WriteLine(nombre);
                Console.Write("Edad:");
                Console.WriteLine(edad);
            }

            public void isMayorEdad()
            {
                if (edad >= 18)
                {
                    Console.Write("Es mayor de edad");
                }
                else
                {
                    Console.Write("No es mayor de edad");
                }
                Console.ReadKey();
            }
        }

            static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.instanciar();
            persona.imprimir();
            persona.isMayorEdad();
        }
    }
}
