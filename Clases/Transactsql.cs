using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Transactsql : ISeverSql
    {
        

        public string GETBASEDETALLES()
        {
            return " SERVER SQL \n Ejecutado para manipular y recuperar datos \n Incluye " +
                "interfaces de acceso \n para varias plataformas de desarrollo \n ";
        }
    }
}