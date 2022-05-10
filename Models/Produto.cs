using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppEcommerce.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Nome { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        [Required]
        public uint Estoque { get; set; }
       
        [Required]
        public Guid IdMarca { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        [StringLength(800)]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }

        [NotMapped]
        public IFormFile ImagemFile { get; set; }

        [Required]
        public Guid IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }

        // public  ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}