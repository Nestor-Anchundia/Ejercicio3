using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Psql : IPostGresql
    {
       

        public string GETBASEDETALLES()
        {
            return "POSGRESQL \n Al conectar realiza \n Transacciones eventuales consistentes \n Y tendra un mayor rendimiento \n";
        }
    }
}