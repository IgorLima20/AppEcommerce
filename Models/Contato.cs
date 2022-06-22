using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu Nome para Contato")]
        [StringLength(100, ErrorMessage = "O Campo Nome deve possuir no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu E-mail para Contato")]
        [StringLength(160, ErrorMessage = "O Campo E-mail deve possuir no máximo 160 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Assunto para Contato")]
        [StringLength(100, ErrorMessage = "O Campo Assunto deve possuir no máximo 100 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua Mensagem para Contato")]
        [StringLength(1000, ErrorMessage = "O Campo Mensagem deve possuir no máximo 1000 caracteres")]
        public string Mensagem { get; set; }
        
        [Required]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTimeOffset DataEnviada { get; set; } = DateTime.Now;
    }
}