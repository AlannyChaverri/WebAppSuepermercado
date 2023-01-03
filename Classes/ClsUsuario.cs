using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsUsuario : ClsConexion
    {
        public string usuario;
        public string clave;
        public string tipoUsuario;

        public ClsUsuario()
        {
            this.usuario = "";
            this.clave = "";
            this.tipoUsuario = "";
        }
        public ClsUsuario(string pUsuario, string pClave, string pTipoUsuario)
        {
            this.usuario = pUsuario;
            this.clave = pClave;
            this.tipoUsuario = pTipoUsuario;
        }

        private DataSet dataTable = new DataSet();
        public DataSet validarusuario(ClsUsuario pClsUsuario)
        {
            try
            {
                SqlDataAdapter adapter;
                DataSet Dts = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "StpValidarUsuario";
                coneccion.Parameters.AddWithValue("@pUsuario", pClsUsuario.usuario);
                coneccion.Parameters.AddWithValue("@pClave", pClsUsuario.clave);
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(dataTable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                Console.WriteLine(Ex.Message);
            }
            return dataTable;
        }
    }
}