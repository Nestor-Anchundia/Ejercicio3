using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Puerto : IOracle
    {
        
        public string GETBASEDETALLES()
        {
            return "ORACLE \n Conectada al puerto \n Alta disponibilidad \n Reduccion de los costos \n ";
        }

    }
}