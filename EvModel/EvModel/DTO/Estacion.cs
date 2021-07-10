using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel
{
    public partial class Estacion
    {
        private string id;
        private string direccion;
        private string region;
        private string capCarga;
        private string horario;

        public string Direccion { get => direccion; set => direccion = value; }
        public string Region { get => region; set => region = value; }
        public string CapCarga { get => capCarga; set => capCarga = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Id { get => id; set => id = value; }
    }
}
