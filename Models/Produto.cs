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

        [Required(ErrorMessage = "Por favor, informe o Nome do Produto")]
        [StringLength(100, ErrorMessage = "O Nome do Produto deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Nome Descrição do Produto")]
        [StringLength(400, ErrorMessage = "O Nome Descrição do Produto deve possuir no máximo 400 caracteres")]
        public string NomeDescricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Preço do Produto")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade em estoque do Produto")]
        public uint Estoque { get; set; }
       
        [Required(ErrorMessage = "Por favor, informe a Descrição do Produto")]
        [StringLength(800, ErrorMessage = "A Descrição do Produto deve possuir no máximo 800 caracteres")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe a Categoria do Produto")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Marca do Produto")]
        public int IdMarca { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        public string ImagemPrincipal { get; set; }

        public ICollection<Imagem> Imagem { get; set; } 

        [Display(Name = "Destaques")]
        public bool ExibirHome { get; set; }
    }
}