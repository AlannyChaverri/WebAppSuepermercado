using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsConsultas : ClsConexion
    {
        public string CodigoArticulo;
        public string Total;
        public string Cantidad;
        public ClsConsultas()
        {
            this.CodigoArticulo = "";
            this.Total = "";
            this.Cantidad = "";

        }
        public ClsConsultas(string pCodigoArticulo, string pTotal, string pCantidad)
        {
            this.CodigoArticulo = pCodigoArticulo;
            this.Total = pTotal;
            this.Cantidad = pCantidad;

        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaVendidos(ClsConsultas pClsConsultas)
        {
            try
            {
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "SptMantenimientoArticulo";
                coneccion.Parameters.AddWithValue("@pCodigo", pClsConsultas.CodigoArticulo);
                coneccion.Parameters.AddWithValue("@pTotal", pClsConsultas.Total);
                coneccion.Parameters.AddWithValue("@pCantidad", pClsConsultas.Cantidad);
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