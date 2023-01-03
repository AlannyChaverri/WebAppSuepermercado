using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsFactura : ClsConexion
    {
        public string NumFactura;
        public string CeduCliente;
        public string NombreCajero;
        public string Fecha;
        public string IdPago;
        public double Total;
        public string IVA;
        public string IdCajero;
        public string IdSucursal;
        public ClsFactura()
        {
            this.NumFactura = "";
            this.CeduCliente = "";
            this.NombreCajero = "";
            this.Fecha = "";
            this.IdPago = "";
            this.Total = 0.0;
            this.IVA = "";
            this.IdCajero = "";
            this.IdSucursal = "";

        }
        public ClsFactura(string pNumFactura, string pCeduCliente, string pNombreCajero, string pFecha,
            string pIdPago, double pTotal, string pIVA, string pIdCajero, string pIdSucursal)
        {
            this.NumFactura = pNumFactura;
            this.CeduCliente = pCeduCliente;
            this.NombreCajero = pNombreCajero;
            this.Fecha = pFecha;
            this.IdPago = pIdPago;
            this.Total = pTotal;
            this.IVA = pIVA;
            this.IdCajero = pIdCajero;
            this.IdSucursal = pIdSucursal;
        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaFactura(ClsFactura pClsFactura, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoFactura1";
                coneccion.Parameters.AddWithValue("@pNumeroFactura", pClsFactura.NumFactura);
                coneccion.Parameters.AddWithValue("@pCedulaCliente", pClsFactura.CeduCliente);
                coneccion.Parameters.AddWithValue("@pNombreEmpleado", pClsFactura.NombreCajero);
                coneccion.Parameters.AddWithValue("@pFechaFacturacion", pClsFactura.Fecha);
                coneccion.Parameters.AddWithValue("@pIdPago", pClsFactura.IdPago);
                coneccion.Parameters.AddWithValue("@pTotalFactura", pClsFactura.Total);
                coneccion.Parameters.AddWithValue("@pIVA", pClsFactura.IVA);
                coneccion.Parameters.AddWithValue("@pIdCajero", pClsFactura.IdCajero);
                coneccion.Parameters.AddWithValue("@pSucursal", pClsFactura.IdSucursal);
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

        public String MantenimientoFactura(ClsFactura pClsFactura, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoFactura1"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pNumeroFactura", pClsFactura.NumFactura);
                    coneccion.Parameters.AddWithValue("@pCedulaCliente", pClsFactura.CeduCliente);
                    coneccion.Parameters.AddWithValue("@pNombreEmpleado", pClsFactura.NombreCajero);
                    coneccion.Parameters.AddWithValue("@pFechaFacturacion", pClsFactura.Fecha);
                    coneccion.Parameters.AddWithValue("@pIdPago", pClsFactura.IdPago);
                    coneccion.Parameters.AddWithValue("@pTotalFactura", pClsFactura.Total);
                    coneccion.Parameters.AddWithValue("@pIVA", pClsFactura.IVA);
                    coneccion.Parameters.AddWithValue("@pIdCajero", pClsFactura.IdCajero);
                    coneccion.Parameters.AddWithValue("@pSucursal", pClsFactura.IdSucursal);
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
