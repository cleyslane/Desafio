using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Produto
    {
        [Key]
        public int produto_id { get; set; }
        [Required]
        public String nome { get; set; }
        [Required]
        public float valor_unitario { get; set; }
        public int qtde_estoque { get; set; }
        public float valor_ultima_venda { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_ultima_venda { get; set; }
    }
}
