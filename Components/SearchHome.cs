// using AppEcommerce.Data;
// using AppEcommerce.Models;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace AppEcommerce.Components
// {
//     public class SearchHome : ViewComponent
//     {
//         private readonly Contexto _contexto;
//         public SearchHome(Contexto contexto)
//         {
//             _contexto = contexto;
//         }

//         public IViewComponentResult Invoke(Guid Id, int? pagina, string sortOrder, string currentFilter, string searchString, int? pageNumber)
//         {
//             ViewData["CurrentSort"] = sortOrder;
//             ViewData["Maior"] = String.IsNullOrEmpty(sortOrder) ? "maior" : "maior";
//             ViewData["Menor"] = String.IsNullOrEmpty(sortOrder) ? "menor" : "menor";
//             ViewData["Todos"] = String.IsNullOrEmpty(sortOrder) ? "todos" : "todos";

//             if (searchString != null)
//             {
//                 pageNumber = 1;
//             }
//             else
//             {
//                 searchString = currentFilter;
//             }

//             ViewData["CurrentFilter"] = searchString;

//             var prod = from p in _contexto.Produtos
//                        select p;

//             if (!String.IsNullOrEmpty(searchString))
//             {
//                 prod = prod.Where(s => s.Nome.Contains(searchString));
//             }

//             switch (sortOrder)
//             {
//                 case "maior":
//                     prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderByDescending(m => m.Valor);
//                     break;
//                 case "menor":
//                     prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderBy(m => m.Valor);
//                     break;
//                 case "todos":
//                     prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
//                     break;
//                 default:
//                     prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
//                     break;
//             }
//             int pageSize = 9;
//             return View(PaginatedList<Produto>.CreateAsync(prod.AsNoTracking(), pageNumber ?? 1, pageSize));
//         }

//     }
// }
