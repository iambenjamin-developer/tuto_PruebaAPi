using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using PruebaAPi.Entities;

namespace PruebaAPi.Dapper
{
    public class UsuariosDALcs
    {

        public static IEnumerable<Roles> Ver()
        {
            string sql = "SELECT Id, Descripcion FROM Roles";

            using (var connection = new SqlConnection("Server=NOTEBENJA;Database=dbTest;Trusted_Connection=True;"))
            {
                var lista = connection.Query<Roles>(sql).ToList();

                return lista;
            }

        }

    }
}
