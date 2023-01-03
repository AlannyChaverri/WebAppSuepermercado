﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsCliente : ClsConexion
    {
        public string Cedula;
        public string Nombre;
        public string PApellido;
        public string SApellido;
        public ClsCliente()
        {
            this.Cedula = "";
            this.Nombre = "";
            this.PApellido = "";
            this.SApellido = "";

        }
        public ClsCliente(string pCedula, string pNombre, string pPApellido, string pSApellido)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.PApellido = pPApellido;
            this.SApellido = pSApellido;
        }
        private DataTable dataTable = new DataTable();
        public DataTable ListaCliente(ClsCliente pClsCliente, string pAccion)
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
                coneccion.CommandText = "SptMantenimientoCliente";
                coneccion.Parameters.AddWithValue("@pCedula", pClsCliente.Cedula);
                coneccion.Parameters.AddWithValue("@pNombre", pClsCliente.Nombre);
                coneccion.Parameters.AddWithValue("@pPrimerApellido", pClsCliente.PApellido);
                coneccion.Parameters.AddWithValue("@pSegundoApellido", pClsCliente.SApellido);
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

        public String MantenimientoCliente(ClsCliente pClsCliente, string pAccion)
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
                    coneccion.CommandText = "SptMantenimientoCliente"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pCedula", pClsCliente.Cedula);
                    coneccion.Parameters.AddWithValue("@pNombre", pClsCliente.Nombre);
                    coneccion.Parameters.AddWithValue("@pPrimerApellido", pClsCliente.PApellido);
                    coneccion.Parameters.AddWithValue("@pSegundoApellido", pClsCliente.SApellido);
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
