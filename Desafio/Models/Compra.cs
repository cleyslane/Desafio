using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int QtdComprada { get; set; }
        public CartaoCredito CartaoCredito { get; set; }
    }
}
