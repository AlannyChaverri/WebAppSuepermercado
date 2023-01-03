using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsProveedor : ClsConexion
    {
        public string Id;
        public string Proveedor;
        public string Encargado;
        public string Direccion;
        public string Correo;
        public string Telefono;
        public string Articulo;
        public ClsProveedor()
        {
            this.Id = "";
            this.Proveedor = "";
            this.Encargado = "";
            this.Direccion = "";
            this.Correo = "";
            this.Telefono = "";
            this.Articulo = "";

        }
        public ClsProveedor(string pId, string pProveedor, string pEncargado, string pDireccion, string pCorreo, string pTelefono, string pArticulo)
        {
            this.Id = pId;
            this.Proveedor = pProveedor;
            this.Encargado = pEncargado;
            this.Direccion = pDireccion;
            this.Correo = pCorreo;
            this.Telefono = pTelefono;
            this.Articulo = pArticulo;

        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaProveedor(ClsProveedor pClsProveedor, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoProveedor";
                coneccion.Parameters.AddWithValue("@pCodigo", pClsProveedor.Id);
                coneccion.Parameters.AddWithValue("@pProveedor", pClsProveedor.Proveedor);
                coneccion.Parameters.AddWithValue("@pEncargado", pClsProveedor.Encargado);
                coneccion.Parameters.AddWithValue("@pDireccion", pClsProveedor.Direccion);
                coneccion.Parameters.AddWithValue("@pCorreo", pClsProveedor.Correo);
                coneccion.Parameters.AddWithValue("@pTelefono", pClsProveedor.Telefono);
                coneccion.Parameters.AddWithValue("@pArticulo", pClsProveedor.Articulo);
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

        public String MantenimientoProveedor(ClsProveedor pClsProveedor, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoProveedor"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pCodigo", pClsProveedor.Id);
                    coneccion.Parameters.AddWithValue("@pProveedor", pClsProveedor.Proveedor);
                    coneccion.Parameters.AddWithValue("@pEncargado", pClsProveedor.Encargado);
                    coneccion.Parameters.AddWithValue("@pDireccion", pClsProveedor.Direccion);
                    coneccion.Parameters.AddWithValue("@pCorreo", pClsProveedor.Correo);
                    coneccion.Parameters.AddWithValue("@pTelefono", pClsProveedor.Telefono);
                    coneccion.Parameters.AddWithValue("@pArticulo", pClsProveedor.Articulo);
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
