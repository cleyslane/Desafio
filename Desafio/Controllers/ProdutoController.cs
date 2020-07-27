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
    public class ProdutoController : ControllerBase
    {
        private ProdutoContext _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }

        //Transforma produto para modelo DTO, o qual oculta a propriedade id 
        private static ProdutoDTO ProdutoToDTO(Produto produto) =>
        new ProdutoDTO
        {   Nome = produto.Nome,
            ValorUnitario = produto.ValorUnitario,
            QtdEstoque =produto.QtdEstoque,
        };

        // GET: api/Produto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetProdutos()
        {
            return Ok(await _context.Produtos.Select(x => ProdutoToDTO(x)).ToListAsync());
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreu um erro desconhecido");
            }

            var produto = await _context.Produtos.FindAsync(id);


            if (produto == null)
            {
                return NotFound("Produto não existe");
            }

            return Ok(produto);
        }

        // PUT: api/Produto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Produto
        [HttpPost]
        public async Task<IActionResult> PostProduto([FromBody] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return Ok("Produto cadastrado com sucesso");
            } else
            {
                return BadRequest("Ocorreu um erro desconhecido");
            }
        }

        // DELETE: api/Produto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> DeleteProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok("Produto excluído com sucesso");
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
