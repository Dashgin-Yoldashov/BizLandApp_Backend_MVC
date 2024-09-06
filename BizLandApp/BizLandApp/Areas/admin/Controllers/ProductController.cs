using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BizLandApp.DAL;
using BizLandApp.Models;

namespace BizLandApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: admin/Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
        }

        // GET: admin/Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: admin/Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(product);
            //}
            if (!product.Img.ContentType.Contains("image/") || product.Img.Length / 1024 > 500)
            {
                ModelState.AddModelError("Img", "File is not valid");
                return View();
            }

            string path = _env.WebRootPath + @"\assets\img\portfolio";
            string filename = Guid.NewGuid().ToString() + product.Img.FileName;
            string final = Path.Combine(path, filename).ToString();
            using (FileStream stream = new FileStream(final, FileMode.Create))
            {
                await product.Img.CopyToAsync(stream);
            }

            product.Image = filename;


            _context.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: admin/Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Image,FilterName,Name,Type,DetailsLink,TextNum,Id")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (true)
            {
                if (product.Img != null)
                {
                    if (!product.Img.ContentType.Contains("image/") || product.Img.Length / 1024 > 500)
                    {
                        ModelState.AddModelError("Img", "File is not valid");
                        return View();
                    }
                    //webrootpath istenilen serverdeki root pathi bize verir
                    string path = _env.WebRootPath + @"\assets\img\portfolio";
                    string filename = Guid.NewGuid().ToString() + product.Img.FileName;
                    string final = Path.Combine(path, filename).ToString();
                    //köhnə image silirik
                    if (System.IO.File.Exists(Path.Combine(path, product.Image)))
                    {
                        System.IO.File.Delete(Path.Combine(path, product.Image));
                    }

                    using (FileStream stream = new FileStream(final, FileMode.Create))
                    {
                        await product.Img.CopyToAsync(stream);
                    }
                    //data bazadaki image e file name i set edirik
                    product.Image = filename;
                }
                try
                {

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: admin/Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            string path = _env.WebRootPath + @"\assets\images\blog";
            string filename = product.Image;
            string final = Path.Combine(path, filename).ToString();
            if (System.IO.File.Exists(final))
            {
                System.IO.File.Delete(final);
            }
            if (product != null)
            {
                _context.products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.products.Any(e => e.Id == id);
        }
    }
}
