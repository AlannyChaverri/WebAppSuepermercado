using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        public object LabelMsgbox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btniniciar_Click(object sender, EventArgs e)
        {
            ClsUsuario vUsuario = new ClsUsuario();
            vUsuario.usuario = txtusuario.Text;
            vUsuario.clave = txtclave.Text;
            DataSet Dts = new DataSet();
            try
            {
                Dts = vUsuario.validarusuario(vUsuario);
                if (Dts.Tables[0].Rows.Count > 0)
                {
                    if (Dts.Tables[0].Rows[0].ItemArray[0].ToString() == txtusuario.Text)
                    {


                        string vTipoUsuarioRoll = Dts.Tables[0].Rows[0]["TipoUsuarioRol"].ToString();
                        Session["Usuario"] = vUsuario.usuario;
                        Session["Clave"] = vUsuario.clave;
                        Session["TipoUsuarioRol"] = vTipoUsuarioRoll;
                        Session.Timeout = 1;
                        switch (vTipoUsuarioRoll)
                        {
                            case "1":
                                Response.Redirect(Page.ResolveUrl("~") + @"Contact.aspx");
                                break;

                            case "Administrador":
                                Response.Redirect(Page.ResolveUrl("~") + @"Contact.aspx");
                                break;

                            case "Proveedor":
                                Response.Redirect(Page.ResolveUrl("~") + @"WebFormArticulo.aspx");
                                break;

                            case "Cajero":
                                Response.Redirect(Page.ResolveUrl("~") + @"WebFormFactura.aspx");
                                break;

                        }


                    }
                    else
                    {
                        LabelMsgbox1.Text = "Usuario No valido";
                    }

                }
                else
                {
                    LabelMsgbox1.Text = "Usuario No valido";

                }




            }
            catch (Exception Ex)
            {
                //LabelMsgbox1.Text = vUsuario.vError + "  " + Ex.Message;
            }
        }

    }
}