﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            string linea;
            Console.Write("Ingrese primer nota:");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese segunda nota:");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese tercer nota:");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            int promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 9)
            {
                Console.Write("Sobresaliente");
            }
            else
            {
                if (promedio >= 5)
                {
                    Console.Write("Aprovado");
                }
                else
                {
                    Console.Write("Suspendido");
                }
            }
            Console.ReadKey();
        }
    }
}
