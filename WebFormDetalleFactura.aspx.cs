using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormDetalleFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtnumero.Text = "";
            this.txtcodigo.Text = "";
            this.txtcantidad.Text = "";
            this.txttotal.Text = "";
        }
        public void MostrarDetalleFactura()
        {
            try
            {
                ClsDetalleFactura vFa = new ClsDetalleFactura();
                GridView1.DataSource = vFa.ListaDetalleFactura(vFa, "S");
                GridView1.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarDetalleFactura();
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vNumero = txtnumero.Text;
                string vCliente = txtcodigo.Text;
                string vNombre = txtcantidad.Text;
                double vFecha = double.Parse(txttotal.Text);

                ClsDetalleFactura vFac = new ClsDetalleFactura(txtnumero.Text,txtcodigo.Text,txtcantidad.Text, double.Parse(txttotal.Text));
                String vResultado = vFac.MantenimientoFactura(vFac, "E");
                Labelmsg.Text = vResultado;
                MostrarDetalleFactura(); 
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
                string vCliente = txtcodigo.Text;
                string vNombre = txtcantidad.Text;
                double vFecha = double.Parse(txttotal.Text);

                ClsDetalleFactura vFac = new ClsDetalleFactura(txtnumero.Text, txtcodigo.Text, txtcantidad.Text, double.Parse(txttotal.Text));
                String vResultado = vFac.MantenimientoFactura(vFac, "M");
                Labelmsg.Text = vResultado;
                MostrarDetalleFactura();
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
                string vCliente = txtcodigo.Text;
                string vNombre = txtcantidad.Text;
                double vFecha = double.Parse(txttotal.Text);

                ClsDetalleFactura vFac = new ClsDetalleFactura(txtnumero.Text, txtcodigo.Text, txtcantidad.Text, double.Parse(txttotal.Text));
                String vResultado = vFac.MantenimientoFactura(vFac, "I");
                Labelmsg.Text = vResultado;
                MostrarDetalleFactura();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
    }
}