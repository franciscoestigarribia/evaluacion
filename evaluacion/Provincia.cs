using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    internal class Provincia
    {
        public string Nombre { get; set; }
        public string Gobernador { get; set; }
        public string Region { get; set; }

        public Pais pais { get; set; }

        public List<Ciudad> ciudades { get; set; } = new();

        public void CargarCiudades(Ciudad ciudade)
        {
            ciudades.Add(ciudade);
            ciudade.provincia=this;
        }
        

    }
}
