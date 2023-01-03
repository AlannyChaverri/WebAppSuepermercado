using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtcedula.Text = "";
            this.txtnombre.Text = "";
            this.txtapellido1.Text = "";
            this.txtapellido2.Text = "";
        }
        public void MostrarClientes()
        {
            try
            {
                ClsCliente vCliente = new ClsCliente();
                GridViewAgente.DataSource = vCliente.ListaCliente(vCliente, "S");
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
                string vCedula = txtcedula.Text;
                string vNombre = txtnombre.Text;
                string vApellido1 = txtapellido1.Text;
                string vApellido2 = txtapellido2.Text;

                ClsCliente vProve = new ClsCliente(txtcedula.Text, txtnombre.Text, txtapellido1.Text,txtapellido2.Text);
                String vResultado = vProve.MantenimientoCliente(vProve, "I");
                Labelmsg.Text = vResultado;
                MostrarClientes();
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
                string vCedula = txtcedula.Text;
                string vNombre = txtnombre.Text;
                string vApellido1 = txtapellido1.Text;
                string vApellido2 = txtapellido2.Text;

                ClsCliente vProve = new ClsCliente(txtcedula.Text, txtnombre.Text, txtapellido1.Text, txtapellido2.Text);
                String vResultado = vProve.MantenimientoCliente(vProve, "M");
                Labelmsg.Text = vResultado;
                MostrarClientes();
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
                string vCedula = txtcedula.Text;
                string vNombre = txtnombre.Text;
                string vApellido1 = txtapellido1.Text;
                string vApellido2 = txtapellido2.Text;

                ClsCliente vProve = new ClsCliente(txtcedula.Text, txtnombre.Text, txtapellido1.Text, txtapellido2.Text);
                String vResultado = vProve.MantenimientoCliente(vProve, "E");
                Labelmsg.Text = vResultado;
                MostrarClientes();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
            MostrarClientes();
        }
    }
}