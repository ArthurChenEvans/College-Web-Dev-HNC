using College_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace College_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository) 
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index(string categoryFilter, string searchQuery)
        {
            ViewBag.CategoryFilter = categoryFilter;
            ViewBag.SearchQuery = searchQuery;

            var allProducts = await _repository.GetAllAsync(categoryFilter, searchQuery);

            return View(allProducts);
        }
    }
}
