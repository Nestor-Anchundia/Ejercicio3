using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercici3.Interfaces
{
    public interface IBaseDatos
    {
        IOracle GETIORACLE();
        IPostGresql GETIPOSTGRESQL();
        ISeverSql GETISEVERSQL();

    }
}