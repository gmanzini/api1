using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Controllers
{
    /// <summary>
    /// Controller para preço de metro quadrado.
    /// </summary>
    ///
    [ApiController]
    [Route("api/PrecificacaoController")]
    public class PrecificacaoController : ControllerBase
    {
        //Declaração DBContext caso houvesse
        //private readonly AppDbContext _context;
        //public PrecificacaoController(AppDbContext context)
        //{
        //    _context = context;
        //}

        // GET: PrecificacaoController

        // GET: api/PrecificacaoController/ValorMetroQuadrado
        /// <summary>
        /// Método para retorno do valor do metro quadrado
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        public ActionResult ValorMetroQuadrado()
        {
            //Retorno caso buscasse no BD
            //return await _context.ValorMetro;
            return Ok(45.50);
        }

     
    }
}
