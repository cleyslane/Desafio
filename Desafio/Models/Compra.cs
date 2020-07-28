using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
   
    public class Compra
    {
        [Required]
        public int produto_id { get; set; }
        [Required]
        public int qtde_comprada { get; set; }
        [Required]
        public CartaoCredito cartao { get; set; }
    }
}
