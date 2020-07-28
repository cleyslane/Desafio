using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Pagamento
    {
        [Required]
        public float valor { get; set; }
        [Required]
        public CartaoCredito cartao { get; set; }
        public String estado { get; set; }
    }
}
