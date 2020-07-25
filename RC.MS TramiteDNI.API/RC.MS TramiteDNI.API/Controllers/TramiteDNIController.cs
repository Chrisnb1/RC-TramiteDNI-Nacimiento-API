using Microsoft.AspNetCore.Mvc;
using RC.MS_TramineDNI.Application.Services;
using RC.MS_TramiteDNI.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.MS_TramiteDNI.API.Controllers
{
    [Route("Api/TramiteDNI")]
    [ApiController]
    public class TramiteDNIController : ControllerBase
    {
        private readonly ITramiteDNIServicio _servicio;

        public TramiteDNIController(ITramiteDNIServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet("ListaTramites")]

        public ActionResult GetTramites(int TramiteDNIid)
        {
            try
            {
                return new JsonResult(_servicio.GetListaTramite(TramiteDNIid)) { StatusCode = 200 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("NroDNI")]
        public int GetNroDNI()
        {
            //Si el Json esta vacio, descomentar.

            //int num_nacional = 45000038;
            //int num_extranjero = 92000000;
            var nro = new NroDNI();
            //nro.Insertar(num_nacional);
            //nro.Insertar(num_extranjero);

            //Apartir del primer get, se agregan los dos numeros. Luego, volver a comentar las anteriores.
            return nro.MostrarDNIN();
        }

        [HttpGet("NroDNIextranjero")]
        public int GetNroDNIextranjero()
        {
            var nro = new NroDNI();  
            return nro.MostrarDNIE();
        }

        [HttpGet("Alta")]

        public bool GetAlta()
        {   
            return true;
        }

    }
}
