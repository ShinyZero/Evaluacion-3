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
                List<PuntoCarga> puntos = new PuntoCargaDAL().GetAll();
                TiposRd1.DataSource = puntos;
                TiposRd1.DataBind();
            }
        }

        protected void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string identificador = IdeTxt.Text.Trim();
                string capMax = CapMaxTxt.Text.Trim();
                int tipo = Convert.ToInt32(TiposRd1.SelectedValue);
                string vida = Vidatxt.Text.Trim();

                PuntoCarga p = new PuntoCarga();
                p.Identificador = identificador;
                p.CapMax = capMax;
                p.Tipo = tipo;
                p.VidaUtil = vida;
                new PuntoCargaDAL().Add(p);
                mensajeLb1.Text = "Punto Carga Registrado";
                limpiar();

            }
            else
            {

            }
        }
        private void limpiar()
        {
            IdeTxt.Text = "";
            CapMaxTxt.Text = "";
            TiposRd1.SelectedIndex = 0;
            Vidatxt.Text = "";
        }
    }
}