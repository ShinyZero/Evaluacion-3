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
    public partial class RegistrarPunto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PuntoCargaDAL cargas = new PuntoCargaDAL();
                TipoRdl.DataSource = cargas.GetAllTipo();
                TipoRdl.DataTextField = "Tipo";
                TipoRdl.DataValueField = "Tipo";
                TipoRdl.DataBind();

                EstacionDAL estaciones = new EstacionDAL();
                IdEstacion.DataSource = estaciones.GetAll();
                IdEstacion.DataTextField = "direccion";
                //seria mejor mostrar la direccion en vez de la id en la grilla de mostrar los puntos de carga
                IdEstacion.DataValueField = "id";
                IdEstacion.DataBind();
            }
        }

        protected void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string identificador = IdeTxt.Text.Trim();
                string capMax = CapMaxTxt.Text.Trim();
                string tipo = TipoRdl.SelectedValue;
                string vida = VidaTxt.Text.Trim();

                PuntoCarga p = new PuntoCarga();
                p.Identificador = identificador;
                p.CapMax = capMax;
                p.Tipo = tipo;
                p.VidaUtil = vida;
                new PuntoCargaDAL().Add(p);
                mensajeLb1.Text = "Punto Carga Registrado";
                limpiar();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('" + "Punto de carga registrado" + "');", true);
            }
            else
            {

            }
        }
        private void limpiar()
        {
            IdeTxt.Text = "";
            CapMaxTxt.Text = "";
            TipoRdl.SelectedIndex = 0;
            VidaTxt.Text = "";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            VidaTxt.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            PuntoCargaDAL test = new PuntoCargaDAL();
            string id = IdeTxt.Text.Trim();
            if (test.PuntoCargaExiste(id))
            {

                CustomValidator1.ErrorMessage = "ATENCION! El identificador de punto de carga ya se encuentra registrado";
                args.IsValid = false;
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('" + "ATENCION! El identificador de la Estacion ya se encuentra registrado" + "');", true);


            }
            else if (id == "")
            {
                CustomValidator1.ErrorMessage = "ATENCION! El identificador no puede quedar vacío";
                args.IsValid = false;
            }
        }
    }
}