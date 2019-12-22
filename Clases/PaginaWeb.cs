using System;
using System.Collections.Generic;
using System.Text;
using Ejercici3.Interfaces;

namespace Ejercici3.Clases
{
    public class PaginaWeb
    {
        IOracle Ioracle;
        ISeverSql Iseversql;
        IPostGresql Ipostgresql;
        public PaginaWeb(IBaseDatos factory)
        {
            Ioracle = factory.GETIORACLE();
            Iseversql = factory.GETISEVERSQL();
            Ipostgresql = factory.GETIPOSTGRESQL();
        }
        public string GETIORACLEBASEDETALLES()
        {
            return Ioracle.GETBASEDETALLES();
        }
        public string GETISEVERSQLBASEDETALLES()
        {
            return Iseversql.GETBASEDETALLES();
        }
        public string GETPOSTGRESQLBASEDETALLES()
        {
            return Ipostgresql.GETBASEDETALLES();
        }

    }
}
