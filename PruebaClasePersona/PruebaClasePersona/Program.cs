﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClasePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.instanciar();
            persona.imprimir();
            persona.isMayorEdad();
        }
    }
}
