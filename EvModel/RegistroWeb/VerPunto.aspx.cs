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
        private void PuntoTabla(List<PuntoCarga> puntos)
        {
            PuntoCargaGrid.DataSource = puntos;
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
            PuntoTabla(puntosCargaDAL.GetAll());
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            TiposRd1.Enabled = !todosChx.Checked;
            if (todosChx.Checked)
            {
                PuntoTabla(puntosCargaDAL.GetAll());
            }
        }

        protected void TiposRd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            int tipoSel = Convert.ToInt32(TiposRd1.SelectedValue);

            List<PuntoCarga> filtrada = puntosCargaDAL.GetAll(tipoSel);
            PuntoTabla(filtrada);
        }
    }
}