using System;
using Ejercici3.Clases;
using Ejercici3.Interfaces;

namespace Ejercici3
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseDatos conectarbasedatos = new Conectar();
            PaginaWeb conectarpaginas = new PaginaWeb(conectarbasedatos);

            Console.WriteLine("*********  CONECTAR PAGINAS WEB **********");
            Console.WriteLine(conectarpaginas.GETIORACLEBASEDETALLES());
            Console.WriteLine(conectarpaginas.GETISEVERSQLBASEDETALLES());
            Console.WriteLine(conectarpaginas.GETPOSTGRESQLBASEDETALLES());

            IBaseDatos ejecutarbasedatos = new Conectar();
            PaginaWeb ejecutarpaginas = new PaginaWeb(ejecutarbasedatos);

            Console.WriteLine("*********  EJECUTAR PAGINAS WEB **********");
            Console.WriteLine(ejecutarpaginas.GETIORACLEBASEDETALLES());
            Console.WriteLine(ejecutarpaginas.GETISEVERSQLBASEDETALLES());
            Console.WriteLine(ejecutarpaginas.GETPOSTGRESQLBASEDETALLES());

            Console.ReadLine();

        }
    }
}
