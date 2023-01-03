using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsInventario : ClsConexion
    {
        public string IdArticulo;
        public string Bodega;
        public string Estante;
        public string Maximo;
        public string Minimo;
        public string Movimiento;
        public string Rotacion;
        public ClsInventario()
        {
            this.IdArticulo = "";
            this.Bodega = "";
            this.Estante = "";
            this.Maximo = "";
            this.Minimo = "";
            this.Movimiento = "";
            this.Rotacion = "";

        }
        public ClsInventario(string pIdArticulo, string pBodega, string pEstante, string pMaximo, string pMinimo, string pMovimiento, string pRotacion)
        {
            this.IdArticulo = pIdArticulo;
            this.Bodega = pBodega;
            this.Estante = pEstante;
            this.Maximo = pMaximo;
            this.Minimo = pMinimo;
            this.Movimiento = pMovimiento;
            this.Rotacion = pRotacion;

        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaInventario(ClsInventario pClsInventario, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoInventario";
                coneccion.Parameters.AddWithValue("@pIdArticulo", pClsInventario.IdArticulo);
                coneccion.Parameters.AddWithValue("@pBodega", pClsInventario.Bodega);
                coneccion.Parameters.AddWithValue("@pEstante", pClsInventario.Estante);
                coneccion.Parameters.AddWithValue("@pMaximo", pClsInventario.Maximo);
                coneccion.Parameters.AddWithValue("@pMinimo", pClsInventario.Minimo);
                coneccion.Parameters.AddWithValue("@pMovimiento", pClsInventario.Movimiento);
                coneccion.Parameters.AddWithValue("@pRotacion", pClsInventario.Rotacion);
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

        public String MantenimientoInventario(ClsInventario pClsInventario, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoInventario"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pIdArticulo", pClsInventario.IdArticulo);
                    coneccion.Parameters.AddWithValue("@pBodega", pClsInventario.Bodega);
                    coneccion.Parameters.AddWithValue("@pEstante", pClsInventario.Estante);
                    coneccion.Parameters.AddWithValue("@pMaximo", pClsInventario.Maximo);
                    coneccion.Parameters.AddWithValue("@pMinimo", pClsInventario.Minimo);
                    coneccion.Parameters.AddWithValue("@pMovimiento", pClsInventario.Movimiento);
                    coneccion.Parameters.AddWithValue("@pRotacion", pClsInventario.Rotacion);
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