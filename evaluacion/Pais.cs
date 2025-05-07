using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    internal class Pais
    {
        public string Nombre { get; set; }

        public List<Provincia> provincias { get; set; } = new();
        public Ciudad ciudadess {  get; set; }
        public void CargarProvincia (Provincia provincia)
        {
            provincias.Add(provincia);
            provincia.pais = this;
            
        }
    }
}
