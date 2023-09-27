using conexionPostgreSQLC_.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionPostgreSQLC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conexion c = new conexion();

            c.conectarBD();

            c.selectAllBD();

            Console.ReadLine();
        }
    }
}
