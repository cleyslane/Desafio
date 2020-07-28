using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class CartaoCredito
    {
     
        [Required]
        public String titular { get; set; }
        [Required]
        [CreditCard(ErrorMessage ="Número do cartão inválido")]
        public String numero { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime data_expiracao { get; set; }
        [Required]
        public String bandeira { get; set; }
        [Required]
        public String cvv { get; set; }

    }
}
