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
        [StringLength(60)]
        public string Nome { get; set; }

        [StringLength(400)]
        public string NomeDescricao { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        [Required]
        public uint Estoque { get; set; }
       

        [StringLength(800)]
        public string Descricao { get; set; }
        

        [Required]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }

        [Required]
        public int IdMarca { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        public string ImagemPrincipal { get; set; }

        [NotMapped]
        public IFormFile ImagemFile { get; set; }

        public ICollection<Imagem> Imagem { get; set; } 

        [Display(Name = "Destaques")]
        public bool ExibirHome { get; set; }
    }
}