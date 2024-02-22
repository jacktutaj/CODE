using Catalog.Infrasctructure.DTO;

namespace Catalog.Infrasctructure.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task CreateAsync(int code, string name, double price);
    }
}