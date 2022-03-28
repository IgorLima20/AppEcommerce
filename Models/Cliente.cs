using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    [Table("Cliente")]
    public class Cliente : User
    {
       [Required]
       [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(9)]
        public string RG { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [NotMapped]
        public int Idade 
        { 
            get => (int)Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.2425);
        }

        public ICollection<Pedido> Pedido { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
    }
}