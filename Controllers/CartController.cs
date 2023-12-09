using Food.Web.Models;
using Food.Web.Models.ViewModels;
using Food.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _dataContext;
        public  CartController(DataContext _context)
        {
            _dataContext = _context;
        }
        public IActionResult Index()
        {
            List<CartItemModel> cartItems = HttpContext.Session.GetJson<List<CartItemModel>>("Cart") ?? new List<CartItemModel>();
            CartItemViewModel cartVM = new()
            {
                CartItems = cartItems,
                GrandTotal = cartItems.Sum(x => x.Quantity * x.Price)
            };
            return View(cartVM);
        }
        public IActionResult Checkout()
		{
			return View("~/Views/Checkout/Index.cshtml");
		}
    }
}