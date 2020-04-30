using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoController : ControllerBase
    {
        [HttpGet]
        [Route("somar/{valor1}/{valor2}")]
        public ActionResult Somar(double valor1, double valor2)
        {
            var soma = valor1 + valor2;
            return Ok(soma);
        }
        [HttpGet]
        [Route("subtrair/{valor1}/{valor2}")]
        public ActionResult Subtrair(double valor1, double valor2)
        {
            var subtrair = valor1 - valor2;
            return Ok(subtrair);
        }
        [HttpGet]
        [Route("multiplicar/{valor1}/{valor2}")]
        public ActionResult Multiplicar(double valor1, double valor2)
        {
            var multiplicar = valor1 * valor2;
            return Ok(multiplicar);
        }
        [HttpGet]
        [Route("dividir/{valor1}/{valor2}")]
        public ActionResult Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
                return StatusCode((int)HttpStatusCode.NotAcceptable,"Não aceito");

            var dividir = valor1 / valor2;
            return Ok(dividir);
        }

    }
}