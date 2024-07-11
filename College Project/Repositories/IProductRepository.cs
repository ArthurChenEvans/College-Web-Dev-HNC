using College_Project.Models.Domain;

namespace College_Project.Repositories
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllAsync(string categoryFilter, string searchQuery);
    }
}
