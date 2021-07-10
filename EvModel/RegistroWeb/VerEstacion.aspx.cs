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
    public partial class VerEstacion : System.Web.UI.Page
    {
        EstacionDAL estacionesDAL = new EstacionDAL();
        private void CargarEstacion(List<Estacion> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstacion(estacionesDAL.GetAll());
            }
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                String IdAEliminar = e.CommandArgument.ToString();
                estacionesDAL.Remove(IdAEliminar);
                CargarEstacion(estacionesDAL.GetAll());
            }
        }
    }
}