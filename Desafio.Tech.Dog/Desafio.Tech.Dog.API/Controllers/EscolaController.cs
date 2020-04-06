using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Tech.Dog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaApplicationService _escolaApplicationService;

        public EscolaController(IEscolaApplicationService escolaApplicationService)
            => _escolaApplicationService = escolaApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] AddEscolaRequest request)
        {
            var response = _escolaApplicationService.Add(request);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody]UpdateEscolaRequest request)
        {
            var response = _escolaApplicationService.Update(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Message);
            else
                return StatusCode((int)HttpStatusCode.BadRequest, response.Errors);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var response = _escolaApplicationService.List();

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpGet]
        [Route("/{idEscola}")]
        public IActionResult Get([FromQuery]GetEscolaByIdRequest request)
        {
            var response = _escolaApplicationService.Get(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpDelete]
        [Route("/{idEscola}")]
        public IActionResult Delete([FromRoute]DeleteEscolaRequest request)
        {
            var response = _escolaApplicationService.Delete(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.NoContent, response);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }
    }
}