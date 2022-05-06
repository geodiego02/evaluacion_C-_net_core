using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Modell
{
    class TablaIntermedia
    {
        public Cliente Cliente { get; set; }
        public int? ClienteId { get; set; }
        public ControlMascotas ControlMascotas { get; set; }
        public int? ControlMascotasId { get; set; }
    }
}
