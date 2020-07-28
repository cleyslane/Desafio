using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Desafio.Models;

namespace Desafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly ProdutoContext _context;

        public ComprasController(ProdutoContext context)
        {
            _context = context;
        }

        private void BaixaNoEstoque(int id, int qtd)
        {
            Produto prod = _context.Produtos.Find(id);
            prod.qtde_estoque -= qtd;
            prod.valor_ultima_venda = prod.valor_unitario * qtd;
            prod.data_ultima_venda = DateTime.Now;
            _context.SaveChanges();
        }

        // POST: api/Compras
        [HttpPost]
        public ActionResult PostCompra([FromBody]Compra compra)
        {
            if (ModelState.IsValid)
            {
                BaixaNoEstoque(compra.produto_id, compra.qtde_comprada);
                return Ok("Venda realizada com sucesso");
            }

            return BadRequest("Ocorreu um erro desconhecido");
       
        }
    }
}
