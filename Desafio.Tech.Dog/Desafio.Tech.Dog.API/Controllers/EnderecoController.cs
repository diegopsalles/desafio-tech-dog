using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Tech.Dog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public EnderecoController(IEnderecoApplicationService enderecoApplicationService)
            => _enderecoApplicationService = enderecoApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] AddEnderecoRequest request)
        {
            var response = _enderecoApplicationService.Add(request);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody]UpdateEnderecoRequest request)
        {
            var response = _enderecoApplicationService.Update(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Message);
            else
                return StatusCode((int)HttpStatusCode.BadRequest, response.Errors);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var response = _enderecoApplicationService.List();

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpGet]
        [Route("{idEndereco}")]
        public IActionResult Get([FromQuery]GetEnderecoByIdRequest request)
        {
            var response = _enderecoApplicationService.Get(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpDelete]
        [Route("{idEndereco}")]
        public IActionResult Delete([FromRoute]DeleteEnderecoRequest request)
        {
            var response = _enderecoApplicationService.Delete(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.NoContent, response);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }


    }
}