using System;
using System.Collections.Generic;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class MotordeBasesdeDatos : ISeverSql
    {
        
        public string GETBASEDETALLES()
        {
            return " SERVER SQL \n Conectada permite habilitar protocolos de servidor \n Configura opciones de protocolo" +
                " \n Por ejemplo los puertos TCP  \n";
        }
    }
}