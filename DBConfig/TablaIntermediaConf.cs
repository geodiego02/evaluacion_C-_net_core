using ENA_Rodrigo_Vera_3600.Modell;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.DBConfig
{
    class TablaIntermediaConf
    {

        public TablaIntermediaConf(EntityTypeBuilder<TablaIntermedia> entityBuilder)
        {
            entityBuilder.HasKey(x => new { x.ClienteId, x.ControlMascotasId });

        }
    }
}
