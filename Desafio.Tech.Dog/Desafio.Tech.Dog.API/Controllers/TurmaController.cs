using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Tech.Dog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaApplicationService _turmaApplicationService;

        public TurmaController(ITurmaApplicationService turmaApplicationService)
            => _turmaApplicationService = turmaApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] AddTurmaRequest request)
        {
            var response = _turmaApplicationService.Add(request);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody]UpdateTurmaRequest request)
        {
            var response = _turmaApplicationService.Update(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Message);
            else
                return StatusCode((int)HttpStatusCode.BadRequest, response.Errors);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var response = _turmaApplicationService.List();

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpGet]
        [Route("{idTurma}")]
        public IActionResult Get([FromQuery]GetTurmaByIdRequest request)
        {
            var response = _turmaApplicationService.Get(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpDelete]
        [Route("{idTurma}")]
        public IActionResult Delete([FromRoute]DeleteTurmaRquest request)
        {
            var response = _turmaApplicationService.Delete(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.NoContent, response);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }
    }
}