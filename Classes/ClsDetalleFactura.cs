using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsDetalleFactura : ClsConexion
    {
        public string NumFactura;
        public string CodigoArticulo;
        public string Cantidad;
        public double Total;
        public ClsDetalleFactura()
            {
        this.NumFactura = "";
        this.CodigoArticulo = "";
        this.Cantidad = "";
        this.Total = 0.0;
        }
        public ClsDetalleFactura(string pNumFactura, string pCodigoArticulo, string pCantidad, double pTotal
                    )
        {
            this.NumFactura = pNumFactura;
            this.CodigoArticulo = pCodigoArticulo;
            this.Cantidad = pCantidad;
            this.Total = pTotal;
        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaDetalleFactura(ClsDetalleFactura pClsDetalleFactura, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoDetalleFactura";
                coneccion.Parameters.AddWithValue("@pNumeroFactura", pClsDetalleFactura.NumFactura);
                coneccion.Parameters.AddWithValue("@pCodigoArticulo", pClsDetalleFactura.CodigoArticulo);
                coneccion.Parameters.AddWithValue("@pCantidad", pClsDetalleFactura.Cantidad);
                coneccion.Parameters.AddWithValue("@pTotalFactura", pClsDetalleFactura.Total);
                coneccion.Parameters.AddWithValue("@pAccion", pAccion);
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

        public String MantenimientoFactura(ClsDetalleFactura pClsDetalleFactura, string pAccion)
        {

            String vResultado = "Error de conexion";
            if (this.Conectando())//Probamos si ahy coneccion...
            {
                try
                {

                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "SptMantenimientoDetalleFactura"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pNumeroFactura", pClsDetalleFactura.NumFactura);
                    coneccion.Parameters.AddWithValue("@pCodigoArticulo", pClsDetalleFactura.CodigoArticulo);
                    coneccion.Parameters.AddWithValue("@pCantidad", pClsDetalleFactura.Cantidad);
                    coneccion.Parameters.AddWithValue("@pTotalFactura", pClsDetalleFactura.Total);
                    coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    vResultado = "Ejecutado con exito";


                }
                catch (Exception Ex)
                {
                    //MessageBox.Show(Ex.Message);
                    vResultado = Ex.Message;

                }
            }


            return vResultado;
        }
    }
}
