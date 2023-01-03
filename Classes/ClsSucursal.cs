using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsSucursal : ClsConexion
    {
        public string Id;
        public string IdEmpresa;
        public string Nombre;
        public string Telefono;
        public string Email;
        public string Direccion;
        public ClsSucursal()
        {
            this.Id = "";
            this.IdEmpresa = "";
            this.Nombre = "";
            this.Telefono = "";
            this.Email = "";
            this.Direccion = "";

        }
        public ClsSucursal(string pId, string pIdEmpresa, string pNombre, string pTelfono, string pEmail, string pDireccion)
        {
            this.Id = pId;
            this.IdEmpresa = pIdEmpresa;
            this.Nombre = pNombre;
            this.Telefono = pTelfono;
            this.Email = pEmail;
            this.Direccion = pDireccion;

        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaSucursa(ClsSucursal pClsSucursal, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoSucursal";
                coneccion.Parameters.AddWithValue("@pCodigo", pClsSucursal.Id);
                coneccion.Parameters.AddWithValue("@pIdEmpresa", pClsSucursal.IdEmpresa);
                coneccion.Parameters.AddWithValue("@pNombre", pClsSucursal.Nombre);
                coneccion.Parameters.AddWithValue("@pTelfono", pClsSucursal.Telefono);
                coneccion.Parameters.AddWithValue("@pEmail", pClsSucursal.Email);
                coneccion.Parameters.AddWithValue("@pDireccion", pClsSucursal.Direccion);
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

        public String MantenimientoSucursal(ClsSucursal pClsSucursal, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoSucursal"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pCodigo", pClsSucursal.Id);
                    coneccion.Parameters.AddWithValue("@pIdEmpresa", pClsSucursal.IdEmpresa);
                    coneccion.Parameters.AddWithValue("@pNombre", pClsSucursal.Nombre);
                    coneccion.Parameters.AddWithValue("@pTelfono", pClsSucursal.Telefono);
                    coneccion.Parameters.AddWithValue("@pEmail", pClsSucursal.Email);
                    coneccion.Parameters.AddWithValue("@pDireccion", pClsSucursal.Direccion);
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