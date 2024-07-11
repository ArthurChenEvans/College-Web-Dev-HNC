
using College_Project.Data;
using College_Project.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace College_Project.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync(string categoryFilter, string searchQuery)
        {
            bool hasCategoryFilter = !string.IsNullOrEmpty(categoryFilter);
            bool hasSearchQuery = !string.IsNullOrEmpty(searchQuery); 

            if(!hasCategoryFilter && !hasSearchQuery)
                return await _context.Products.ToListAsync();

            var query = _context.Products.AsQueryable();

            if(hasCategoryFilter)
                query = query.Where(x => x.Category == categoryFilter);

            if(hasSearchQuery)
                query = query.Where(x => x.Name.Contains(searchQuery));

            return await query.ToListAsync();
        }
    }
}
