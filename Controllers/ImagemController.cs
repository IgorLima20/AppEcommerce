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

namespace AppEcommerce.Controllers
{
    public class ImagemController : Controller
    {
        private readonly Contexto _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public ImagemController(Contexto context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Imagem
        public async Task<IActionResult> Index(int? cid)
        {
            if (cid.HasValue)
            {
                var produto = await _context.Produtos.FindAsync(cid);
                if (produto != null)
                {
                    _context.Entry(produto).Collection(c => c.Imagem).Load();
                    ViewBag.Produto = produto;
                    return View(produto.Imagem);
                }
            }
            return RedirectToAction("Index", "Produto");
        }

        // GET: Imagem/Details/5
        public async Task<IActionResult> Details(int? id, int? cid)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem
                .FirstOrDefaultAsync(m => m.IdImagem == id);
            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }

        // GET: Imagem/Create
        public async Task<IActionResult> Create(int? cid)
        {
            var produto = await _context.Produtos.FindAsync(cid);
            ViewBag.Produto = produto;
            return View();
        }

        // POST: Imagem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagemFile")] Imagem imagem, [FromForm] int? idProduto)
        {
            if (idProduto.HasValue)
            {
                var produto = await _context.Produtos.FindAsync(idProduto);
                ViewBag.Produto = produto;


                string wwwRootPatch = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(imagem.ImagemFile.FileName);
                string extension = Path.GetExtension(imagem.ImagemFile.FileName);
                imagem.Img = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPatch + "/img/", filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await imagem.ImagemFile.CopyToAsync(fileStream);
                }
                var idImagem = produto.Imagem.Count() > 0 ? produto.Imagem.Max(e => e.IdImagem) + 1 : 1;
                imagem.IdImagem = idImagem;
                _context.Produtos.FirstOrDefault(c => c.Id == idProduto).Imagem.Add(imagem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Imagem");

            }
            else
            {
                return RedirectToAction("Index", "Produto");
            }
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Id,ImagemFile")] Imagem imagem)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         string wwwRootPatch = _hostEnvironment.WebRootPath;
        //         string filename = Path.GetFileNameWithoutExtension(imagem.ImagemFile.FileName);
        //         string extension = Path.GetExtension(imagem.ImagemFile.FileName);
        //         imagem.Img = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
        //         string path = Path.Combine(wwwRootPatch + "/img/", filename);
        //         using (var fileStream = new FileStream(path, FileMode.Create))
        //         {
        //             await imagem.ImagemFile.CopyToAsync(fileStream);
        //         }

        //         _context.Add(imagem);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(imagem);
        // }

        // GET: Imagem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem.FindAsync(id);
            if (imagem == null)
            {
                return NotFound();
            }
            return View(imagem);
        }

        // POST: Imagem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Img")] Imagem imagem)
        {
            if (id != imagem.IdImagem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemExists(imagem.IdImagem))
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
            return View(imagem);
        }

        // GET: Imagem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem
                .FirstOrDefaultAsync(m => m.IdImagem == id);
            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }

        // POST: Imagem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagem = await _context.Imagem.FindAsync(id);
            _context.Imagem.Remove(imagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagemExists(int id)
        {
            return _context.Imagem.Any(e => e.IdImagem == id);
        }
    }
}
