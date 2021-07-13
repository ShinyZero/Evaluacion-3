using EvModel;
using EvModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroWeb
{
    public partial class VerPunto : System.Web.UI.Page
    {

        PuntoCargaDAL puntosCargaDAL = new PuntoCargaDAL();
        private void PuntoTabla(List<PuntoCarga> cargas)
        {
            PuntoCargaGrid.DataSource = cargas;
            PuntoCargaGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PuntoTabla(puntosCargaDAL.GetAll());
            }
        }

        protected void PuntoCargaGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Boton Actualizar

            PuntoTabla(puntosCargaDAL.GetAll());

        }

        protected void TipoRdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            string tipoSel = TipoRdl.SelectedValue;

            List<PuntoCarga> filtrar = puntosCargaDAL.GetAllFiltro(tipoSel);
            PuntoTabla(filtrar);
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            TipoRdl.Enabled = !todosChx.Checked;
            if (todosChx.Checked)
            {
                PuntoTabla(puntosCargaDAL.GetAll());
            }
        }

        protected void PuntoCargaGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentificadorTxt.Text = ((GridView)sender).SelectedRow.Cells[0].Text;
            Vidatxt.Text = ((GridView)sender).SelectedRow.Cells[3].Text;
        }

        protected void ActualizarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string identificador = IdentificadorTxt.Text.Trim();
                string capMax = capaTxt.Text.Trim();
                string tipo = TipoRdl.SelectedValue;
                string vida = Vidatxt.Text.Trim();

                PuntoCarga p = new PuntoCargaDAL().Update(identificador);
                p.Identificador = identificador;
                p.CapMax = capMax;
                p.Tipo = tipo;
                p.VidaUtil = vida;
                mensajeLb1.Text = "Punto Carga actualizado";
                PuntoTabla(puntosCargaDAL.GetAll());
                limpiar();

            }
            else
            {

            }

        }
        private void limpiar()
        {
            IdentificadorTxt.Text = "";
            capaTxt.Text = "";
            TipoRdl.SelectedIndex = 0;
            Vidatxt.Text = "";
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Vidatxt.Text = Calendar1.SelectedDate.ToShortDateString();
        }

    }
}
