using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Tech.Dog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoApplicationService _alunoApplicationService;

        public AlunoController(IAlunoApplicationService alunoApplicationService)
            => _alunoApplicationService = alunoApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] AddAlunoRequest request)
        {
            var response = _alunoApplicationService.Add(request);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody]UpdateAlunoRequest request)
        {
            var response = _alunoApplicationService.Update(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Message);
            else
                return StatusCode((int)HttpStatusCode.BadRequest, response.Errors);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var response = _alunoApplicationService.List();

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpGet]
        [Route("{idAluno}")]
        public IActionResult Get([FromQuery]GetAlunoByIdRequest request)
        {
            var response = _alunoApplicationService.Get(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.OK, response.Result);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }

        [HttpDelete]
        [Route("{idAluno}")]
        public IActionResult Delete([FromQuery]DeleteAlunoRequest request)
        {
            var response = _alunoApplicationService.Delete(request);

            if (response.Success)
                return StatusCode((int)HttpStatusCode.NoContent, response);
            else
                return StatusCode((int)HttpStatusCode.NotFound, response.Errors);
        }


    }
}