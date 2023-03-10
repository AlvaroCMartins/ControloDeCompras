using ControloDeCompras.Data;
using ControloDeCompras.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControloDeCompras.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ShoppingListController(ApplicationDbContext bd) /*injetar serviços*/
        {
            _db = bd;
        }

        public IActionResult Index()
        {
            IEnumerable<ShoppingList> objShoppingList = _db.ShoppingLists;

            return View(objShoppingList);
        }

        // Get
        public IActionResult Create()
        {
            return View();
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ShoppingList obj)
        {
            if(obj.Genero == obj.Nome)
            {
                ModelState.AddModelError("Genero", "Os campos Genero e Nome não podem ter o mesmo valor.");
            }

            if (ModelState.IsValid)
            {
                _db.ShoppingLists.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
