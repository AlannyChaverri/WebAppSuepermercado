using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppSupermercadoPatitosSA.Classes
{
    public class ClsConexion
    {
         public String coneccion = "Data Source=PC-ALANNY;Initial Catalog=db_Supermercados_Patitos_SA;Integrated Security=True";
       // public String coneccion = "Data Source = sql5097.site4now.net; Initial Catalog= db_a7ca36_supepatitos;User id=db_a7ca36_supepatitos_admin;Password=Patitos1;";

        public SqlConnection cnn;

        public Boolean Conectando()
        {


            try
            {
                cnn = new SqlConnection(this.coneccion);
                //Probamos que ahy coneccion.

                cnn.Close();
                //Cerramos la coneccion
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
