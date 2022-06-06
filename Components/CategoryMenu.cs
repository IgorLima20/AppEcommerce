using AppEcommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Components
{
    public class CategoryMenu:ViewComponent
    {
        private readonly Contexto _contexto;
        public CategoryMenu(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _contexto.Categorias.OrderBy(p => p.Nome).Take(12);
            return View(categorias);
        }

    }
}
