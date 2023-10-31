using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionSQL
    {

        static string conexionstring = "Data Source=.;Initial Catalog = puntodeventa;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, string Contraseña)
        {
            int count;
            con.Open();
            string Query = "Select count(*) From PERSONA where USUARIO =  '" + Usuario + "'" +
                " and CONTRASEÑA = '"+ Contraseña+ "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;

        }

    }
}
