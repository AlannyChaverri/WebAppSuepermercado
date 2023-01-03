using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{

    public class ClsArticulo : ClsConexion
    {
        public string Id;
        public string Descripcion;
        public string PrecioVenta;
        public string PrecioCosto;
        public string Stock;
        public string IdTipo;
        public string IdProveedor;
        public string FechaIngreso; //	YYYY-MM-DD
        public ClsArticulo()
        {
            this.Id = "";
            this.Descripcion = "";
            this.PrecioVenta = "";
            this.PrecioCosto = "";
            this.Stock = "";
            this.IdTipo = "";
            this.IdProveedor = "";
            this.FechaIngreso = "";

        }
        public ClsArticulo(string pId, string pDescripcion, string pPrecioVenta, string pPrecioCosto, string pStock, string pIdTipo, string pIdProveedor, string pFechaIngreso)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
            this.PrecioVenta = pPrecioVenta;
            this.PrecioCosto = pPrecioCosto;
            this.Stock = pStock;
            this.IdTipo = pIdTipo;
            this.IdProveedor = pIdProveedor;
            this.FechaIngreso = pFechaIngreso;

        }
        public DataTable ListaArticuloHaVencer(ClsArticulo pClsArticulo, string pAccion)
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
                coneccion.CommandText = "StpArticuloVencimiento";
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
        public DataTable ListaArticuloMasVendido(ClsArticulo pClsArticulo, string pAccion)
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
                coneccion.CommandText = "StpArticuloMasVendido";
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

        private DataTable dataTable = new DataTable();
        public DataTable ListaArticulo(ClsArticulo pClsArticulo, string pAccion)
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
                coneccion.Parameters.AddWithValue("@pCodigo", pClsArticulo.Id);
                coneccion.Parameters.AddWithValue("@pDescripcion", pClsArticulo.Descripcion);
                coneccion.Parameters.AddWithValue("@pPrecioVenta", pClsArticulo.PrecioVenta);
                coneccion.Parameters.AddWithValue("@pPrecioCosto", pClsArticulo.PrecioCosto);
                coneccion.Parameters.AddWithValue("@pStock", pClsArticulo.Stock);
                coneccion.Parameters.AddWithValue("@pIdTipo", pClsArticulo.IdTipo);
                coneccion.Parameters.AddWithValue("@pIdProveedor", pClsArticulo.IdProveedor);
                coneccion.Parameters.AddWithValue("@pFechaIngreso", pClsArticulo.FechaIngreso);
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

        public String MantenimientoArticulo(ClsArticulo pClsArticulo, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoArticulo"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pCodigo", pClsArticulo.Id);
                    coneccion.Parameters.AddWithValue("@pDescripcion", pClsArticulo.Descripcion);
                    coneccion.Parameters.AddWithValue("@pPrecioVenta", pClsArticulo.PrecioVenta);
                    coneccion.Parameters.AddWithValue("@pPrecioCosto", pClsArticulo.PrecioCosto);
                    coneccion.Parameters.AddWithValue("@pStock", pClsArticulo.Stock);
                    coneccion.Parameters.AddWithValue("@pIdTipo", pClsArticulo.IdTipo);
                    coneccion.Parameters.AddWithValue("@pIdProveedor", pClsArticulo.IdProveedor);
                    coneccion.Parameters.AddWithValue("@pFechaIngreso", pClsArticulo.FechaIngreso);
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
        
    
