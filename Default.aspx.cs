using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSupermercadoPatitosSA
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("WebFormLogin.aspx");
            //validarSession();
        }

        //private void validarSession()
        //{
        //    try
        //    {
        //        string tipo = (string)Session["TipoUsuarioRol"];
        //        if (tipo.Equals(""))
        //        {
        //            Response.Redirect(Page.ResolveUrl("~") + @"WebFormLogin.aspx");
        //        }
        //        else
        //        {
        //            //se queda en la pagina actual;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Response.Redirect(Page.ResolveUrl("~") + @"WebFormLogin.aspx");
        //    }
        //}
    }
}

