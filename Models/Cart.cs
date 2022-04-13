// using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace AppEcommerce.Models
// {
//     public class Cart
//     {
//         [Key]
//         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//         public int RecordId { get; set; }
//         public string CartId { get; set; }
//         public int ProdutoId { get; set; }
//         public int Count { get; set; }
//         public DateTime DateCadastro { get; set; }
//         public virtual Produto Produto { get; set; }

//         /*Essa classe é muito parecida com as outras que usamos até agora,
//          * com exceção do atributo [key] para a propriedade recordId. 
//          * Nossos itens de carrinho terão um identificador de cadeia de caracteres
//          * chamado Cartid para permitir compras anônimas, mas a tabela inclui uma 
//          * chave primária de inteiro chamada recordId. Por convenção, Entity Framework 
//          * código primeiro espera que a chave primária para uma tabela denominada cart seja a Cartid ou ID,
//          * mas podemos substituir facilmente isso por meio de anotações ou código, 
//          * se desejarmos. Este é um exemplo de como podemos usar as convenções simples em Entity Framework Code-First
//          * quando elas se adequarem a nós, mas não estamos restritos por elas quando não estiverem.
//          */

//     }
// }
