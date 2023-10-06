using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Etec.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        [HttpGet("obter-aluno")]
        public IActionResult Obter()
        {
            return Ok("Gustavo");
        }

        [HttpGet("listar-alunos")]
        public IActionResult Listar()
        {
            var nomes = new List<string>();
            nomes.Add("Priscila");
            nomes.Add("Rafael Tabolka");
            nomes.Add("João Pedro");
            nomes.Add("Rafael Luz");
            nomes.Add("Igor");
            nomes.Add("Wellington");
            nomes.Add("Ruan");
            nomes.Add("Rafael Calera");
            nomes.Add("Olga");
            nomes.Add("João Pedro Alves");
            nomes.Add("Ana Beatriz");
            nomes.Add("Isaque");
            nomes.Add("Gustavo Caruzo");
            nomes.Add("Leandro");
            nomes.Add("Ana Carolina");
            nomes.Add("Kamily");
            nomes.Add("Gustavo");
            nomes.Add("João Vitor");

            //return Ok(nomes.OrderBy(n => n));
            //return Ok(nomes.Where(n => n.ToLower().StartsWith("j")));
            return Ok(nomes.Contains("fa"));
        }
    }
}