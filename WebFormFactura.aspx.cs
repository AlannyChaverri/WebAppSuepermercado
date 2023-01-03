using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtnumero.Text = "";
            this.txtcliente.Text = "";
            this.txtnombrecajero.Text = "";
            this.txtfecha.Text = "";
            this.txtpago.Text = "";
            this.txttotal.Text = "";
            this.txtiva.Text = "";
            this.txtidcajero.Text = "";
            this.txtsucuesal.Text = "";
        }
        public void MostrarClientes()
        {
            try
            {
                ClsFactura vFa = new ClsFactura();
                GridView1.DataSource = vFa.ListaFactura(vFa, "S");
                GridView1.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
            LimpiarCamposTexto();
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vNumero = txtnumero.Text;
                string vCliente = txtcliente.Text;
                string vNombre = txtnombrecajero.Text;
                string vFecha = txtfecha.Text;
                string vPago = txtpago.Text;
                double vTotal = double.Parse(txttotal.Text);
                string vIVA = txtiva.Text;
                string vIdCajero = txtidcajero.Text;
                string vSucursal = txtsucuesal.Text;

                ClsFactura vFac = new ClsFactura(txtnumero.Text, txtcliente.Text, txtnombrecajero.Text, txtfecha.Text,
                   txtpago.Text, double.Parse(txttotal.Text), txtiva.Text, txtidcajero.Text, txtsucuesal.Text);
                String vResultado = vFac.MantenimientoFactura(vFac, "E");
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
                string vNumero = txtnumero.Text;
                string vCliente = txtcliente.Text;
                string vNombre = txtnombrecajero.Text;
                string vFecha = txtfecha.Text;
                string vPago = txtpago.Text;
                double vTotal = double.Parse(txttotal.Text);
                string vIVA = txtiva.Text;
                string vIdCajero = txtidcajero.Text;
                string vSucursal = txtsucuesal.Text;

                ClsFactura vFac = new ClsFactura(txtnumero.Text, txtcliente.Text, txtnombrecajero.Text, txtfecha.Text,
                   txtpago.Text, double.Parse(txttotal.Text), txtiva.Text, txtidcajero.Text, txtsucuesal.Text);
                String vResultado = vFac.MantenimientoFactura(vFac, "M");
                Labelmsg.Text = vResultado;
                MostrarClientes();
                LimpiarCamposTexto();
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
                string vNumero = txtnumero.Text;
                string vCliente = txtcliente.Text;
                string vNombre = txtnombrecajero.Text;
                string vFecha = txtfecha.Text;
                string vPago = txtpago.Text;
                double vTotal = double.Parse(txttotal.Text);
                string vIVA = txtiva.Text;
                string vIdCajero = txtidcajero.Text;
                string vSucursal = txtsucuesal.Text;

                ClsFactura vFac = new ClsFactura(txtnumero.Text, txtcliente.Text, txtnombrecajero.Text, txtfecha.Text,
                   txtpago.Text, double.Parse(txttotal.Text),txtiva.Text, txtidcajero.Text, txtsucuesal.Text);
                String vResultado = vFac.MantenimientoFactura(vFac, "I");
                Labelmsg.Text = vResultado;
                MostrarClientes();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
    }
}