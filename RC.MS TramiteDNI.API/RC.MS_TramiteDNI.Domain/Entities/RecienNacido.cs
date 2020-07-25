using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_NacimientoDefuncion.Domain.Entities
{
    public class RecienNacido
    {
        public int RecienNacidoId { get; set; }
        public int Persona_1_Id { get; set; }
        public int Persona_2_Id { get; set; }
        public int NumeroActa { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public bool PartidaNacimiento { get; set; }
        public int TramiteNacimientoId { get; set; }
        public TramiteNacimiento TramiteNacimientoNavigator { get; set; }
    }
}
