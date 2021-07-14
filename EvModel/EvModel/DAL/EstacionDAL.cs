using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvModel.DAL
{
    public class EstacionDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();
        public static List<Estacion> regiones = new List<Estacion>()
        {
            new Estacion()
            {
                Region="Arica y Parinacota",
                NRegion="XV"
            },
            new Estacion()
            {
                Region="Tarapaca",
                NRegion="I"
            },
            new Estacion()
            {
                Region="Antofagasta",
                NRegion="II"
            },
            new Estacion()
            {
                Region="Atacama",
                NRegion="III"
            },
            new Estacion()
            {
                Region="Coquimbo",
                NRegion="IV"
            },
            new Estacion()
            {
                Region="Valparaiso",
                NRegion="V"
            },
            new Estacion()
            {
                Region="Region Metropolitana",
                NRegion="Region M"
            },
            new Estacion()
            {
                Region="Bernardo O'higgins",
                NRegion="VI"
            },
            new Estacion()
            {
                Region="Maule",
                NRegion="VII"
            },
            new Estacion()
            {
                Region="Ñuble",
                NRegion="XVI"
            },
            new Estacion()
            {
                Region="BioBio",
                NRegion="VIII"
            },
            new Estacion()
            {
                Region="Araucania",
                NRegion="IX"
            },
            new Estacion()
            {
                Region="Los Rios",
                NRegion="XIV"
            },
            new Estacion()
            {
                Region="Los Lagos",
                NRegion="X"
            },
            new Estacion()
            {
                Region="Aysén",
                NRegion="XI"
            },
            new Estacion()
            {
                Region="Magallanes",
                NRegion="XII"
            },
        };

        public List<Estacion> GetAllRegiones()
        {
            return regiones;
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public void Add(Estacion e)
        {
            estaciones.Add(e);
        }

        public void Remove(String Id)
        {
            Estacion estacion = estaciones.Find(e => e.Id == Id);
            estaciones.Remove(estacion);
        }

        public bool EstacionExiste(string id)
        {

            Estacion estacion = estaciones.Find(e => e.Id == id);
            if (estacion == null)
            {
                return false;
            }
            return true;
        }
    }
}
