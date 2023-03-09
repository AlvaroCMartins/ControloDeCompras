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
    }
}
