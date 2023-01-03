using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppSupermercadoPatitosSA.Classes;

namespace WebAppSupermercadoPatitosSA
{
    public partial class WebFormArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCamposTexto()
        {
            this.txtid.Text = "";
            this.txtdescripcion.Text = "";
            this.txtpventa.Text = "";
            this.txtpcosto.Text = "";
            this.txtstock.Text = "";
            this.txttipo.Text = "";
            this.txtproveedor.Text = "";
            this.txtfecha.Text = "";
        }
        public void MostrarArticulo()
        {
            try
            {
                ClsArticulo vArti = new ClsArticulo();
                GridViewAgente.DataSource = vArti.ListaArticulo(vArti, "S");
                GridViewAgente.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarArticulo();
            LimpiarCamposTexto();   

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vId = txtid.Text;
                string vDescripcio = txtdescripcion.Text;
                string vPCosto = txtpventa.Text;
                string vPVenta = txtpcosto.Text;
                string vStock = txtstock.Text;
                string vTipo = txttipo.Text;
                string vIdProveedor = txtproveedor.Text;
                string vFercha = txtfecha.Text;

                ClsArticulo vProve = new ClsArticulo(txtid.Text, txtdescripcion.Text, txtpventa.Text, txtpcosto.Text, txtstock.Text, txttipo.Text, txtproveedor.Text, txtfecha.Text);
                String vResultado = vProve.MantenimientoArticulo(vProve, "E");
                Labelmsg.Text = vResultado;
                MostrarArticulo();
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
                string vDescripcio = txtdescripcion.Text;
                string vPCosto = txtpventa.Text;
                string vPVenta = txtpcosto.Text;
                string vStock = txtstock.Text;
                string vTipo = txttipo.Text;
                string vIdProveedor = txtproveedor.Text;
                string vFercha = txtfecha.Text;

                ClsArticulo vProve = new ClsArticulo(txtid.Text, txtdescripcion.Text, txtpventa.Text,
                    txtpcosto.Text, txtstock.Text, txttipo.Text, txtproveedor.Text, txtfecha.Text);
                String vResultado = vProve.MantenimientoArticulo(vProve, "M");
                Labelmsg.Text = vResultado;
                MostrarArticulo();
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
                string vId = txtid.Text;
                string vDescripcio = txtdescripcion.Text;
                string vPCosto = txtpventa.Text;
                string vPVenta = txtpcosto.Text;
                string vStock = txtstock.Text;
                string vTipo = txttipo.Text;
                string vIdProveedor = txtproveedor.Text;
                string vFercha = txtfecha.Text;

                ClsArticulo vProve = new ClsArticulo(txtid.Text, txtdescripcion.Text, txtpventa.Text,
                    txtpcosto.Text, txtstock.Text, txttipo.Text, txtproveedor.Text, txtfecha.Text);
                String vResultado = vProve.MantenimientoArticulo(vProve, "I");
                Labelmsg.Text = vResultado;
                MostrarArticulo();
                LimpiarCamposTexto();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnmasvendido_Click(object sender, EventArgs e)
        {
            try
            {
                ClsArticulo vArti = new ClsArticulo();
                GridViewAgente.DataSource = vArti.ListaArticuloMasVendido(vArti, "A");
                GridViewAgente.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }

        protected void btnvencimiento_Click(object sender, EventArgs e)
        {
            try
            {
                ClsArticulo vArti = new ClsArticulo();
                GridViewAgente.DataSource = vArti.ListaArticuloHaVencer(vArti, "A");
                GridViewAgente.DataBind();
            }
            catch (Exception Ex)
            {
                Labelmsg.Text = Ex.Message;
            }
        }
    }
}