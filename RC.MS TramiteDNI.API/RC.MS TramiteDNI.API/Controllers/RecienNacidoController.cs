using Microsoft.AspNetCore.Mvc;
using RC.MS_NacimientoDefuncion.Application.Services;
using RC.MS_NacimientoDefuncion.Domain.DTOs;
using RC.MS_NacimientoDefuncion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.MS_NacimientoDefuncionAPI.Controllers
{
    [Route("Api/RecienNacido")]
    [ApiController]
    public class RecienNacidoController : ControllerBase
    {
        private readonly IRecienNacidosServices _service;

        public RecienNacidoController(IRecienNacidosServices service)
        {
            _service = service;
        }

        [HttpGet("ListaRecienNacidos")]
        public IActionResult ListaNuevosEjemplares(int RecienNacidoId)
        {
            try
            {
                return new JsonResult(_service.ListaRecienNacidos(RecienNacidoId)) { StatusCode = 200 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(RecienNacidosDTO dto)
        {
            try
            {
                return new JsonResult(_service.CrearRecienNacido(dto)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
