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
using Microsoft.AspNetCore.Authorization;

namespace AppEcommerce.Controllers
{
    [Authorize(Roles = "Administrador, Moderador")]
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
            return RedirectToAction("Index", "Imagem");
        }

        // GET: Imagem/Details/5
        public async Task<IActionResult> Details(int? id, int? cid)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _context.Produtos.FindAsync(cid);
            ViewBag.Produto = produto;
            var imagem = await _context.Imagens.Where(p => p.IdProduto == cid)
            .FirstOrDefaultAsync(m => m.IdImagem == id);
            // .FirstOrDefaultAsync(m => m.IdImagem == id);
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
        public async Task<IActionResult> Create([Bind("Id,Img,IdProduto")] Imagem imagem, int? idProduto, IFormFile file)
        {
            if (idProduto.HasValue)
            {
                var produto = await _context.Produtos.FindAsync(idProduto);
                ViewBag.Produto = produto;

                string wwwRootPath = _hostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"img\produtos");
                    var extension = Path.GetExtension(file.FileName);
                    using (var stream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    imagem.Img = @"\img\produtos\" + fileName + extension;
                }
                _context.Imagens.Add(imagem);
                await _context.SaveChangesAsync();
                ViewBag.Concluido = "OK";
                return View(imagem);

            }
            else
            {
                return RedirectToAction("Index", "Imagem");
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
        public async Task<IActionResult> Edit(int? id, int? cid)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _context.Produtos.FindAsync(cid);
            ViewBag.Produto = produto;

            var imagem = await _context.Imagens.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("IdImagem,Img,IdProduto")] Imagem imagem,  IFormFile file, int? idProduto)
        {
          if (id != imagem.IdImagem)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(idProduto);
            ViewBag.Produto = produto;

            if (ModelState.IsValid)
            {

                try
                {   
                    String wwwRootPath = _hostEnvironment.WebRootPath;
                    if (file != null)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(wwwRootPath, @"img\produtos");
                        var extension = Path.GetExtension(file.FileName);
                        
                        if (imagem.Img != null)
                        {
                            var oldImage = Path.Combine(wwwRootPath, imagem.Img.TrimStart('\\'));
                            if (System.IO.File.Exists(oldImage))
                            {
                                System.IO.File.Delete(oldImage);
                            }
                        }
                        
                        using (var stream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        imagem.Img = @"\img\produtos\" + fileName + extension;
                    }
                    _context.Update(imagem);
                    await _context.SaveChangesAsync();
                    ViewBag.Concluido = "OK";
                    return View(imagem);

                    // var produto = await _context.Produtos.FindAsync(idProduto);
                    // ViewBag.Produto = produto;

                    // var imgP = await _context.Imagens.FindAsync(id);


                    // string wwwRootPatch = _hostEnvironment.WebRootPath;
                    // string filename = Path.GetFileNameWithoutExtension(imagem.ImagemFile.FileName);
                    // string extension = Path.GetExtension(imagem.ImagemFile.FileName);
                    // imagem.Img = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    // string path = Path.Combine(wwwRootPatch + "/img/", filename);
                    // using (var fileStream = new FileStream(path, FileMode.Create))
                    // {
                    //     await imagem.ImagemFile.CopyToAsync(fileStream);
                    // }
                    // var idImagem = produto.Imagem.Count() > 0 ? imagem.IdProduto.Where(e => e.IdImagem) + 1 : 1;
                    // imagem.IdImagem = idImagem;

                    // imgP = imagem;
                    // _context.Update(imgP);
                    // await _context.SaveChangesAsync();
                   
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
            }
            return View(imagem);
        }

        // GET: Imagem/Delete/5
        public async Task<IActionResult> Delete(int? id, int? cid)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(cid);
            ViewBag.Produto = produto;
            var imagem = await _context.Imagens
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
        public async Task<IActionResult> DeleteConfirmed(int id, int cid)
        {
            var produto = await _context.Produtos.FindAsync(cid);
            ViewBag.Produto = produto;
            var imagem = await _context.Imagens.FindAsync(id);
            String wwwRootPath = _hostEnvironment.WebRootPath;

            if (imagem.Img != null)
            {
                var oldImage = Path.Combine(wwwRootPath, imagem.Img.TrimStart('\\'));
                if (System.IO.File.Exists(oldImage))
                {
                    System.IO.File.Delete(oldImage);
                }
            }
            _context.Remove(imagem);
            await _context.SaveChangesAsync();
            ViewBag.Concluido = "OK";
            return View(imagem);
        }

        private bool ImagemExists(int id)
        {
            return _context.Imagens.Any(e => e.IdImagem == id);
        }
    }
}
