using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers
{
    public class PagamentosController : ControllerBase
    {
        private readonly ProdutoContext _context;

        public PagamentosController(ProdutoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult PostPagmentos([FromBody]float value, CartaoCredito cartao)
        {
            Pagamento pag = null;

            pag.valor = value;
            pag.cartao = cartao;

            if (pag.valor > 100.0)
            {
                pag.estado = "APROVADO";
                return Ok(pag.estado);
            }

            pag.estado = "REJEITADO";
            return BadRequest(pag.estado);


        }
    }
}