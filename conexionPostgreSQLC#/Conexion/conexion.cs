using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionPostgreSQLC_.Conexion
{
    public class conexion
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=_altair458;Database =gestorBibliotecaPersonal");

        public void conectarBD()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Conexion satisfactoria");
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }
        
        public void selectAllBD()
        {
            NpgsqlCommand npc = new NpgsqlCommand("SELECT * FROM gbp_almacen.gbp_alm_cat_libros");
            npc.Connection = conn;
            conn.Open();
            NpgsqlDataReader dr = npc.ExecuteReader();

            while (dr.Read())
            {
                Console.Write("{0}\t{1}\t{2}\t{3}\t{4}", dr[0], dr[1], dr[2], dr[3], dr[4]);
                Console.WriteLine(" ");
            }
            conn.Close(); 
        }



    }
}
