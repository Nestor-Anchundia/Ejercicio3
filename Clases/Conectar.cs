using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class Conectar : IBaseDatos
    {
       
        public IOracle GETIORACLE()
        {
            return new Puerto();
        }

        public IPostGresql GETIPOSTGRESQL()
        {
            return new Psql();
        }
        public ISeverSql GETISEVERSQL()
        {
            return new MotordeBasesdeDatos();
        }

    }
}
