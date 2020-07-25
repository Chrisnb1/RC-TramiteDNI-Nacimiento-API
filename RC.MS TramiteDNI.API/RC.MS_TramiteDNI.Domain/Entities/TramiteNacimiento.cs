using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_NacimientoDefuncion.Domain.Entities
{
    public class TramiteNacimiento
    {
        public int TramiteNacimientoId { get; set; }
        public RecienNacido RecienNacidoNavigator { get; set; }

    }
}
