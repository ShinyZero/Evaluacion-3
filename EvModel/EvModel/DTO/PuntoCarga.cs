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
        private int tipo;
        private string capMax;
        private string vidaUtil;

        public int Tipo { get => tipo; set => tipo = value; }
        public string CapMax { get => capMax; set => capMax = value; }
        public string VidaUtil { get => vidaUtil; set => vidaUtil = value; }
        public string Identificador { get => identificador; set => identificador = value; }
    }
}
