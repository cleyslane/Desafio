using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class CartaoCredito
    {
        [Key]
        [CreditCard]
        public String Numero { get; set; }
        public String Titular { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataExpiracao { get; set; }
        public String Bandeira { get; set; }
        public String Cvv { get; set; }

    }
}
