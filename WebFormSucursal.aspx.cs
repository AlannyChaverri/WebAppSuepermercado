using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtid.Text = "";
            this.txtidempresa.Text = "";
            this.txtnombre.Text = "";
            this.txttelefono.Text = "";
            this.txtemail.Text = "";
            this.txtdirecion.Text = "";
        }
        public void MostarSucursal()
        {
            try
            {
                ClsSucursal vSucursal = new ClsSucursal();
                GridViewAgente.DataSource = vSucursal.ListaSucursa(vSucursal, "S");
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
                string vCodigo = txtidempresa.Text;
                string vNombre = txtnombre.Text;
                string vDescripcion = txttelefono.Text;
                string vFoto = txtemail.Text;
                string vEspecie = txtdirecion.Text;

                ClsSucursal vSucursal = new ClsSucursal(txtid.Text, txtidempresa.Text, txtnombre.Text, txttelefono.Text, txtemail.Text, txtdirecion.Text);
                String vResultado = vSucursal.MantenimientoSucursal(vSucursal, "I");
                Labelmsg.Text = vResultado;
                MostarSucursal();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostarSucursal();
            LimpiarCamposTexto();
        }

        protected void btnModifi_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtid.Text;
                string vCodigo = txtidempresa.Text;
                string vNombre = txtnombre.Text;
                string vDescripcion = txttelefono.Text;
                string vFoto = txtemail.Text;
                string vEspecie = txtdirecion.Text;

                ClsSucursal vSucursal = new ClsSucursal(txtid.Text, txtidempresa.Text, txtnombre.Text, txttelefono.Text, txtemail.Text, txtdirecion.Text);
                String vResultado = vSucursal.MantenimientoSucursal(vSucursal, "M");
                Labelmsg.Text = vResultado;
                MostarSucursal();
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
                string vCodigo = txtidempresa.Text;
                string vNombre = txtnombre.Text;
                string vDescripcion = txttelefono.Text;
                string vFoto = txtemail.Text;
                string vEspecie = txtdirecion.Text;

                ClsSucursal vSucursal = new ClsSucursal(txtid.Text, txtidempresa.Text, txtnombre.Text, txttelefono.Text, txtemail.Text, txtdirecion.Text);
                String vResultado = vSucursal.MantenimientoSucursal(vSucursal, "E");
                Labelmsg.Text = vResultado;
                MostarSucursal();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
    }
}