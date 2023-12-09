
using Food.Web.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Food.Web.Controllers
{
    public class ProductController: Controller
    {
        private readonly DataContext _dataContext;
            public IActionResult Index()
            {
            return View();
            }
		public ProductController(DataContext context)
		{
			_dataContext = context;
		}
		public async Task<IActionResult> Details(int Id)
            {
                if(Id == null) return RedirectToAction("Index");
			var productsById = _dataContext.Products.Where(p => p.ID == Id).FirstOrDefault();

			return View(productsById);
            }
        }
    }


