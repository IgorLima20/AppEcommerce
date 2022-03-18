using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public double Valor { get; set; }

        [Required]
        public uint Estoque { get; set; }
       
        [Required]
        public Guid IdMarca { get; set; }

        [Required]
        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        [StringLength(300)]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }

        [Required]
        public Guid IdCategoria { get; set; }

        [Required]
        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
    }
}