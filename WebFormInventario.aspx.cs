using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtidarticulo.Text = "";
            this.txtbodega.Text = "";
            this.txtestante.Text = "";
            this.txtmaximo.Text = "";
            this.txtminimo.Text = "";
            this.txtmovimiento.Text = "";
            this.txtrotacion.Text = "";
        }
        public void MostrarInventario()
        {
            try
            {
                ClsInventario vInve = new ClsInventario();
                GridViewAgente.DataSource = vInve.ListaInventario(vInve, "S");
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
                string vId = txtidarticulo.Text;
                string vDescripcio = txtbodega.Text;
                string vPCosto = txtestante.Text;
                string vPVenta = txtmaximo.Text;
                string vStock = txtminimo.Text;
                string vTipo = txtmovimiento.Text;
                string vIdProveedor = txtrotacion.Text;

                ClsInventario vInventario = new ClsInventario(txtidarticulo.Text, txtbodega.Text, txtestante.Text,
                    txtmaximo.Text, txtminimo.Text, txtmovimiento.Text, txtrotacion.Text);
                String vResultado = vInventario.MantenimientoInventario(vInventario, "I");
                Labelmsg.Text = vResultado;
                MostrarInventario();
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
                string vId = txtidarticulo.Text;
                string vDescripcio = txtbodega.Text;
                string vPCosto = txtestante.Text;
                string vPVenta = txtmaximo.Text;
                string vStock = txtminimo.Text;
                string vTipo = txtmovimiento.Text;
                string vIdProveedor = txtrotacion.Text;

                ClsInventario vInventario = new ClsInventario(txtidarticulo.Text, txtbodega.Text, txtestante.Text,
                    txtmaximo.Text, txtminimo.Text, txtmovimiento.Text, txtrotacion.Text);
                String vResultado = vInventario.MantenimientoInventario(vInventario, "M");
                Labelmsg.Text = vResultado;
                MostrarInventario();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarInventario();
            LimpiarCamposTexto();

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtidarticulo.Text;
                string vDescripcio = txtbodega.Text;
                string vPCosto = txtestante.Text;
                string vPVenta = txtmaximo.Text;
                string vStock = txtminimo.Text;
                string vTipo = txtmovimiento.Text;
                string vIdProveedor = txtrotacion.Text;

                ClsInventario vInventario = new ClsInventario(txtidarticulo.Text, txtbodega.Text, txtestante.Text,
                    txtmaximo.Text, txtminimo.Text, txtmovimiento.Text, txtrotacion.Text);
                String vResultado = vInventario.MantenimientoInventario(vInventario, "E");
                Labelmsg.Text = vResultado;
                MostrarInventario();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
    }
}