using EPerfumesFinal.Data;
using EPerfumesFinal.Data.Services;
using EPerfumesFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EPerfumesFinal.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IMarcasService _service;

        public MarcasController(IMarcasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Marca/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Marca_Name, Marca_Pic_URL")] Marca marca)
        {
            if (!ModelState.IsValid)
            {
                return View(marca);
            }
            await _service.AddAsync(marca);
            return RedirectToAction(nameof(Index));
        }

        //Get: Marcas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var MarcaDetails = await _service.GetByIDAsync(id);
            if (MarcaDetails == null) return View("NotFound");
            return View(MarcaDetails);
        }

        //Get: Marca/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var MarcaDetails = await _service.GetByIDAsync(id);
            if (MarcaDetails == null) return View("Not Found");
            return View(MarcaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Marca_ID,Marca_Name, Marca_Pic_URL")] Marca marca)
        {
            if (!ModelState.IsValid)
            {
                return View(marca);
            }
            await _service.UpdateAsync(id, marca);
            return RedirectToAction(nameof(Index));
        }

        //Get: Marca/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var MarcaDetails = await _service.GetByIDAsync(id);
            if (MarcaDetails == null) return View("Not Found");
            return View(MarcaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var MarcaDetails = await _service.GetByIDAsync(id);
            if (MarcaDetails == null) return View("Not Found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
