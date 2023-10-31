using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConexionSQLN
    {


        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user,string pass)
        {
           

            return cn.consultalogin(user, pass);
        }
        public DataTable ConsultaDT()
        {
            return cn.ConsultaUsuariosDG();
        }
        public DataTable ConsultainvenDT()
        {
            return cn.ConsultaInventarioDG();
        }
        public int InsertarUsuario(string nom, string apel, string edad, string tel, string user, string pass)
        {


            return cn.InsertarUsuario(nom, apel, edad, tel, user, pass);
        }
        public int ModificarUsuario(string nom, string apel, string edad, string tel, string user, string pass)
        {

            
            return cn.ModificarUsuario(nom, apel, edad, tel, user, pass);
        }
        public int EliminarUsuario(string edad)
        {

            return cn.EliminarUsuario(edad);
        }
        public int Agregar(string id, string prod, string prov, string pre, string cant)
        {


          return cn.Agregar(id, prod, prov, pre, cant);
        }
        public int Editar(string id, string prod, string prov, string pre, string cant)
        {


            return cn.Editar(id, prod, prov, pre, cant);
        }
        public int Eliminar(string id)
        {

            return cn.Eliminar(id);
        }
        public string consultaFactura()
        {
            

            return cn.consultaFactura();



        }
  
    
    
    }





}
