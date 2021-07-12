using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel.DAL
{
    public class PuntoCargaDAL
    {
        private static List<PuntoCarga> puntoCargas = new List<PuntoCarga>();
        public static List<PuntoCarga> cargas = new List<PuntoCarga>()
        {
           new PuntoCarga()
           {
               Tipo="Dual"
           },
          new PuntoCarga()
            {
               Tipo = "Electrico"
            }
        };

        public void Add(PuntoCarga p)
        {
            puntoCargas.Add(p);
        }

        public PuntoCarga Update(String identificador)
        {
            return puntoCargas.Find(p => p.Identificador == identificador);
        }
        
        public List<PuntoCarga> GetAll()
        {
            return puntoCargas; 
        }

        public List<PuntoCarga> GetAllTipo()
        {
            return cargas;
        }

        public List<PuntoCarga> GetAllFiltro(string tipo)
        {

              return puntoCargas.FindAll(p => p.Tipo == tipo);

            
            
        }
    }
}
