using RC.MS_NacimientoDefuncion.Domain.DTOs;
using RC.MS_NacimientoDefuncion.Domain.Entities;
using RC.MS_NacimientoDefuncion.Domain.Queries;
using RC.MS_TramiteDNI.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_NacimientoDefuncion.Application.Services
{
    public interface IRecienNacidosServices
    {
        RecienNacido CrearRecienNacido(RecienNacidosDTO entidad);
        IEnumerable<RecienNacidosDTO> ListaRecienNacidos(int RecienNacidoId);

    }

    public class RecienNacidosServices : IRecienNacidosServices
    {
        private readonly IGenericRepository _repository;
        private readonly IRecienNacidoQuery _query;

        public RecienNacidosServices(IGenericRepository repository, IRecienNacidoQuery query)
        {
            _repository = repository;
            _query = query;
        }
        public RecienNacido CrearRecienNacido(RecienNacidosDTO entidad)
        {
            var tramite = new TramiteNacimiento();
            _repository.Add(tramite);

            var nuevo = new RecienNacido()
            {
                Persona_1_Id = entidad.Persona_1_Id,
                Persona_2_Id = entidad.Persona_2_Id,
                NumeroActa = entidad.NumeroActa,
                Genero = entidad.Genero,
                FechaNacimiento = entidad.FechaNacimiento,
                LugarNacimiento = entidad.LugarNacimiento,
                PartidaNacimiento = entidad.PartidaNacimiento,
                TramiteNacimientoNavigator = tramite
            };


            _repository.Add(nuevo);
            return nuevo;
        }

        public IEnumerable<RecienNacidosDTO> ListaRecienNacidos(int RecienNacidoId)
        {
            return _query.GetListaRecienNacidos(RecienNacidoId);
        }
    }
}
