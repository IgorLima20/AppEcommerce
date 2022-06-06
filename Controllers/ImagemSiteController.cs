using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppEcommerce.Data;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AppEcommerce.Controllers
{
    public class ImagemSiteController : Controller
    {
        private readonly Contexto _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public ImagemSiteController(Contexto context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: ImagemSite
        public async Task<IActionResult> Index()
        {
            return View(await _context.ImagensSite.ToListAsync());
        }

        // GET: ImagemSite/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemSite = await _context.ImagensSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagemSite == null)
            {
                return NotFound();
            }

            return View(imagemSite);
        }

        // GET: ImagemSite/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImagemSite/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ordem,Img,Carrosel,Secundaria")] ImagemSite imagemSite, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"img\promocoes");
                    var extension = Path.GetExtension(file.FileName);
                    using (var stream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    imagemSite.Img = @"\img\promocoes\" + fileName + extension;
                }
                _context.Add(imagemSite);
                await _context.SaveChangesAsync();
                ViewBag.Concluido = "OK";
                return View(imagemSite);
            }
            return View(imagemSite);
        }

        // GET: ImagemSite/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemSite = await _context.ImagensSite.FindAsync(id);
            if (imagemSite == null)
            {
                return NotFound();
            }
            return View(imagemSite);
        }

        // POST: ImagemSite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ordem,Img,Carrosel,Secundaria")] ImagemSite imagemSite, IFormFile file)
        {
            if (id != imagemSite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    String wwwRootPath = _hostEnvironment.WebRootPath;
                    if (file != null)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(wwwRootPath, @"img\promocoes");
                        var extension = Path.GetExtension(file.FileName);

                        if (imagemSite.Img != null)
                        {
                            var oldImage = Path.Combine(wwwRootPath, imagemSite.Img.TrimStart('\\'));
                            if (System.IO.File.Exists(oldImage))
                            {
                                System.IO.File.Delete(oldImage);
                            }
                        }

                        using (var stream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        imagemSite.Img = @"\img\promocoes\" + fileName + extension;
                    }

                    _context.Update(imagemSite);
                    await _context.SaveChangesAsync();
                    ViewBag.Concluido = "OK";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemSiteExists(imagemSite.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(imagemSite);
            }
            return View(imagemSite);
        }

        // GET: ImagemSite/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemSite = await _context.ImagensSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagemSite == null)
            {
                return NotFound();
            }

            return View(imagemSite);
        }

        // POST: ImagemSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagemSite = await _context.ImagensSite.FindAsync(id);
            if (imagemSite.Img != null)
            {
                var imagemPath = Path.Combine(_hostEnvironment.WebRootPath, "img\\promocoes", imagemSite.Img);
                if (System.IO.File.Exists(imagemPath))
                {
                    System.IO.File.Delete(imagemPath);
                }
            }
            _context.ImagensSite.Remove(imagemSite);
            await _context.SaveChangesAsync();
            ViewBag.Concluido = "OK";
            return View(imagemSite);
        }

        private bool ImagemSiteExists(int id)
        {
            return _context.ImagensSite.Any(e => e.Id == id);
        }
    }
}
