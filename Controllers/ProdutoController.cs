using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppEcommerce.Data;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace AppEcommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly Contexto _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutoController(Contexto context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }


        // GET: Produto
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Produtos.Include(p => p.Categoria).Include(p => p.Marca);
            return View(await contexto.ToListAsync());
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nome");
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nome");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Valor,Estoque,IdMarca,Descricao,ImagemFile,IdCategoria")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPatch = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(produto.ImagemFile.FileName);
                string extension = Path.GetExtension(produto.ImagemFile.FileName);
                produto.ImagemPrincipal = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPatch + "/img/", filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await produto.ImagemFile.CopyToAsync(fileStream);
                }

                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nome", produto.IdCategoria);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nome", produto.IdMarca);
            return View(produto);
        }

        // public async Task<IActionResult> Upload(IFormFile file)
        // {
        //     var fileDic = "Files";
        //     string filePath = Path.Combine(_hostEnvironment.WebRootPath, fileDic);
        //     if (!Directory.Exists(filePath))
        //     {
        //         Directory.CreateDirectory(filePath);
        //     }
        //     var fileName = file.FileName;
        //     filePath = Path.Combine(filePath, fileName);
        //     using (FileStream fs = System.IO.File.Create(filePath))
        //     {
        //         file.CopyTo(fs);
        //     }
        //     return View();
        // }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nome", produto.IdCategoria);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nome", produto.IdMarca);
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Valor,Estoque,IdMarca,Descricao,ImagemFile,IdCategoria")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string wwwRootPatch = _hostEnvironment.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(produto.ImagemFile.FileName);
                    string extension = Path.GetExtension(produto.ImagemFile.FileName);
                    produto.ImagemPrincipal = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPatch + "/img/", filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await produto.ImagemFile.CopyToAsync(fileStream);
                    }
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nome", produto.IdCategoria);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nome", produto.IdMarca);
            return View(produto);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
