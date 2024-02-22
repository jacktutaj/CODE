using Catalog.Core.Domain;
using Catalog.Core.Repositories;

namespace Catalog.Infrasctructure.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private static ISet<Product> _products = new HashSet<Product>();

        public async Task AddAsync(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
            => await Task.FromResult(_products);
    }
}