using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class ProdutoDTO
    {
        public String nome { get; set; }
        public float valor_unitario { get; set; }
        public int qtde_estoque { get; set; }
    }
}
