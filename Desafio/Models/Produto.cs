using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float ValorUnitario { get; set; }
        public int QtdEstoque { get; set; }
    }
}
