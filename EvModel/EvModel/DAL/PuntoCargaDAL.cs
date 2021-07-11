using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel.DAL
{
    public class PuntoCargaDAL
    {
        private static List<PuntoCarga> puntoCargas = new List<PuntoCarga>()
        {
            new PuntoCarga()
            {
                Tipo="Trafico"
            },
            new PuntoCarga()
            {
                Tipo="Consumo"
            },
            new PuntoCarga()
            {
                Tipo="Dual"
            },
            new PuntoCarga()
            {
                Tipo="Electrico"
            },
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
    }
}
