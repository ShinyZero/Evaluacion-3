using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel.DAL
{
    public class EstacionDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>()
        {
            new Estacion()
            {
                Region="Arica y Parinacota"
            },
            new Estacion()
            {
                Region="Tarapaca"
            },
            new Estacion()
            {
                Region="Antofagasta"
            },
            new Estacion()
            {
                Region="Atacama"
            },
            new Estacion()
            {
                Region="Coquimbo"
            },
            new Estacion()
            {
                Region="Valparaiso"
            },
            new Estacion()
            {
                Region="Region Metropolitana"
            },
            new Estacion()
            {
                Region="Bernardo O'higgins"
            },
            new Estacion()
            {
                Region="Maule"
            },
            new Estacion()
            {
                Region="Ñuble"
            },
            new Estacion()
            {
                Region="BioBio"
            },
            new Estacion()
            {
                Region="Araucania"
            },
            new Estacion()
            {
                Region="Los Rios"
            },
            new Estacion()
            {
                Region="Los Lagos"
            },
            new Estacion()
            {
                Region="Aysén"
            },
            new Estacion()
            {
                Region="Magallanes"
            },
        };
        public void Add(Estacion e)
        {
            estaciones.Add(e);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public void Remove(String Id)
        {
            Estacion estacion = estaciones.Find(e => e.Id == Id);
            estaciones.Remove(estacion);
        }
    }
}
