using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTerminal.Controllers
{
    [Route("api/sge")]
    [ApiController]
    public class SGEController : ControllerBase
    {
        [HttpGet]
        [Route("/degrees")]
        public async Task<IActionResult> GetDegreesList()
        {
            return null;
        }
    }
}
