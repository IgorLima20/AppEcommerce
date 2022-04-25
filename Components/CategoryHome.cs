using AppEcommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Components
{
    public class CategoryHome:ViewComponent
    {
        private readonly Contexto _contexto;
        public CategoryHome(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _contexto.Categorias.OrderBy(p => p.Nome).Take(4);
            return View(categorias);
        }
    }
}
