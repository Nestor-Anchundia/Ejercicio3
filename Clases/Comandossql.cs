using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Comandossql : IOracle
    {
        
        public string GETBASEDETALLES()
        {
            return " ORACLE \n Para ejecutar debe introducir el bloque SQL o PL/SQL en el editor de comandos \n " +
                "Se pueden ejecutar comandos tanto de lenguaje de manipulación de bases de datos (DML)\n";
        }
    }
}