using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Ejecutar : IBaseDatos
    {
       
        public IOracle GETIORACLE()
        {
            return new Comandossql();
        }

        public IPostGresql GETIPOSTGRESQL()
        {
            return new Servidor();
        }

        public ISeverSql GETISEVERSQL()
        {
            return new Transactsql();
        }
    }
}
