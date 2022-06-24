// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
// using Microsoft.EntityFrameworkCore;

// namespace AppEcommerce.Models
// {
//     [Table("Endereco")]
//     public class Endereco
//     {
//         [Key]
//         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//         public int IdEndereco { get; set; }

//         [Required]
//         [StringLength(100)]
//         public string Logradouro { get; set; }

//         [Required]
//         [StringLength(10)]
//         public string Numero { get; set; }

//         [StringLength(100)]
//         public string Complemento { get; set; }

//         [Required]
//         [StringLength(60)]
//         public string Bairro { get; set; }

//         [Required]
//         [StringLength(60)]
//         public string Cidade { get; set; }

//         [Required]
//         [StringLength(2)]
//         public string Estado { get; set; }

//         [Required]
//         [StringLength(9)]
//         public string CEP { get; set; }

//         [Required]
//         public string Referencia { get; set; }

//         public bool Selecionado { get; set; }


//         [NotMapped]
//         public string EnderecoCompleto
//         {
//             get
//             {
//                 return $"{Logradouro}, {Numero}, {Complemento}, {Bairro}, {Cidade}, {Estado}, CEP {CEP}";
//             }
//         }
//     }
// }