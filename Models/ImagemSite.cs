using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    public class ImagemSite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe a ordem que a Imagem será exibida")]
        public uint Ordem { get; set; }

        public string Img { get; set; }

        public bool Carrosel { get; set; }

        public bool Secundaria { get; set; }
    }
}