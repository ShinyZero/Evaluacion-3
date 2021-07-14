using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel
{
    public partial class PuntoCarga
    {
        private string identificador;
        private string tipo;
        private string capMax;
        private string vidaUtil;
        private string estacion;

        public string Tipo { get => tipo; set => tipo = value; }
        public string CapMax { get => capMax; set => capMax = value; }
        public string VidaUtil { get => vidaUtil; set => vidaUtil = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Estacion { get => estacion; set => estacion = value; }
    }
}
