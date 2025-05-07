using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    internal class Ciudad
    {
        public string nombre {  get; set; }
        public int CantHabitantes { get; set; }
        public double Superficies { get; set; }

        public Provincia provincia {  get; set; }


    }
}
