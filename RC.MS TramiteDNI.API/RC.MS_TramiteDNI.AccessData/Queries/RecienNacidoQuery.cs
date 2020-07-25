using RC.MS_NacimientoDefuncion.Domain.DTOs;
using RC.MS_NacimientoDefuncion.Domain.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RC.MS_NacimientoDefuncion.AccessData.Commands
{
    public class RecienNacidoQuery : IRecienNacidoQuery
    {
        private readonly IDbConnection _conection;
        private readonly Compiler _sqlKataCompiler;

        public RecienNacidoQuery(IDbConnection conection, Compiler sqlKataCompiler)
        {
            _conection = conection;
            _sqlKataCompiler = sqlKataCompiler;
        }

        public IEnumerable<RecienNacidosDTO> GetListaRecienNacidos(int RecienNacidoId)
        {
            var db = new QueryFactory(_conection, _sqlKataCompiler);

            var nacido = db.Query("RecienNacidos")
                .Select("RecienNacidoId", "Persona_1_Id", "Persona_2_Id", "NumeroActa", "Genero", "FechaNacimiento", "LugarNacimiento", "PartidaNacimiento", "TramiteNacimientoId")
                .When(RecienNacidoId > 0, q => q.WhereLike("RecienNacidoId", $"%{RecienNacidoId}%"));


            var result = nacido.Get<RecienNacidosDTO>();
            return result.ToList();
        }
    }
}
