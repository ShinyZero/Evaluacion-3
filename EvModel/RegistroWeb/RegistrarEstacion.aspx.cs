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
    public partial class RegistrarEstacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                EstacionDAL regiones = new EstacionDAL();
                estacionDBL.DataSource = regiones.GetAllRegiones();
                estacionDBL.DataTextField = "Region";
                estacionDBL.DataValueField = "NRegion";
                estacionDBL.DataBind();
            }
            
        }
        protected void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string id = IdTxt.Text.Trim();
                string direccion = DireccionTxt.Text.Trim();
                String regiones = estacionDBL.SelectedValue; 
                string CapCarga = CapCargaTxt.Text.Trim();
                string horario = horarioTxt.Text.Trim();

                Estacion es = new Estacion();

                es.Id = id;
                es.Direccion = direccion;
                es.Region = regiones;
                es.CapCarga = CapCarga;
                es.Horario = horario;

                new EstacionDAL().Add(es);
                //mensajeLbl.Text = "Estacion Ingresada";
                limpiar();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('" + "Estacion registrada" + "');", true);
            }
            else
            {

            }
           
        }

        private void limpiar()
        {
            IdTxt.Text = "";
            DireccionTxt.Text = "";
            estacionDBL.SelectedIndex = 0;
            CapCargaTxt.Text = "";
            horarioTxt.Text = "";
        }

        protected void HorarioCV_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            EstacionDAL test = new EstacionDAL();
            string id = IdTxt.Text.Trim();
            if (test.EstacionExiste(id))
            {

                CustomValidator1.ErrorMessage = "ATENCION! El identificador de la Estacion ya se encuentra registrado";
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