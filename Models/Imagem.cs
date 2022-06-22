using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppEcommerce.Models
{
    public class Imagem
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImagem { get; set; }

        [Required(ErrorMessage = "Por favor, informe uma Imagem para o Cadastro")]
        public string Img { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }  

    }
}