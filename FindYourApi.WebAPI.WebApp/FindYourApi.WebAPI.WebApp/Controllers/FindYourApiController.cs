using FindYourApi.WebAPI.WebApp.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourApi.WebAPI.WebApp.Controllers
{
    [ApiController]
    [Route("find-your-api")]
    public class FindYourApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction()
        {
            var mensagemResponse = new MensagemResponse
            {
                Status = 200,
                Message = "Olá, seja bem vindo ao Find Your Api."
            };
            return Ok(mensagemResponse);
        }
    }
}
