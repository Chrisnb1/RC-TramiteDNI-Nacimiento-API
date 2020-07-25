using RC.MS_NacimientoDefuncion.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_NacimientoDefuncion.Domain.Queries
{
    public interface IRecienNacidoQuery
    {
        IEnumerable<RecienNacidosDTO> GetListaRecienNacidos(int RecienNacidoId);

    }
}
