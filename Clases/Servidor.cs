using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Servidor : IPostGresql
    {
        
        public string GETBASEDETALLES()
        {
            return " POSTGRES \n Al ejecutarse pueden ser escritos en varios lenguajes " +
                "con la potencia que cada uno de ellos da \n " +
                " desde las operaciones básicas de programación  \n hasta las complejidades " +
                "de la programación orientada a objetos";
        }
    }
}