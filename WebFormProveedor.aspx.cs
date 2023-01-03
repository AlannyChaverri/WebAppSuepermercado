using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtid.Text = "";
            this.txtproveedor.Text = "";
            this.txtencargado.Text = "";
            this.txtdireccion.Text = "";
            this.txtemail.Text = "";
            this.txttelefono.Text = "";
            this.txtarticulo.Text = "";
        }
        public void MostrarProveedor()
        {
            try
            {
                ClsProveedor vProve = new ClsProveedor();
                GridViewAgente.DataSource = vProve.ListaProveedor(vProve, "S");
                GridViewAgente.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtid.Text;
                string vProveedor = txtproveedor.Text;
                string vEncargado = txtencargado.Text;
                string vDireccion = txtdireccion.Text;
                string vEmail = txtemail.Text;
                string vTelefono = txttelefono.Text;
                string vArticulo = txtarticulo.Text;

                ClsProveedor vProve = new ClsProveedor(txtid.Text, txtproveedor.Text, txtencargado.Text, txtdireccion.Text, txtemail.Text, txttelefono.Text, txtarticulo.Text);
                String vResultado = vProve.MantenimientoProveedor(vProve, "I");
                Labelmsg.Text = vResultado;
                MostrarProveedor();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnModifi_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtid.Text;
                string vProveedor = txtproveedor.Text;
                string vEncargado = txtencargado.Text;
                string vDireccion = txtdireccion.Text;
                string vEmail = txtemail.Text;
                string vTelefono = txttelefono.Text;
                string vArticulo = txtarticulo.Text;

                ClsProveedor vProve = new ClsProveedor(txtid.Text, txtproveedor.Text, txtencargado.Text, txtdireccion.Text, txtemail.Text, txttelefono.Text, txtarticulo.Text);
                String vResultado = vProve.MantenimientoProveedor(vProve, "M");
                Labelmsg.Text = vResultado;
                MostrarProveedor();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtid.Text;
                string vProveedor = txtproveedor.Text;
                string vEncargado = txtencargado.Text;
                string vDireccion = txtdireccion.Text;
                string vEmail = txtemail.Text;
                string vTelefono = txttelefono.Text;
                string vArticulo = txtarticulo.Text;

                ClsProveedor vProve = new ClsProveedor(txtid.Text, txtproveedor.Text, txtencargado.Text, txtdireccion.Text, txtemail.Text, txttelefono.Text, txtarticulo.Text);
                String vResultado = vProve.MantenimientoProveedor(vProve, "E");
                Labelmsg.Text = vResultado;
                MostrarProveedor();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarProveedor();
            LimpiarCamposTexto();
        }
    }
}