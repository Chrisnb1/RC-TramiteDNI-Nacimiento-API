using RC.MS_NacimientoDefuncion.Domain.DTOs;
using RC.MS_NacimientoDefuncion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_NacimientoDefuncion.Domain.Queries
{
    public interface ITramiteNacimientoQuery
    {
        IEnumerable<TramiteNacimiento> GetListaTramites(int TramiteId);
    }
}
