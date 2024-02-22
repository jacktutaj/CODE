using Catalog.Core.Domain;
using Catalog.Core.Repositories;
using Catalog.Infrasctructure.DTO;
using System.Collections;

namespace Catalog.Infrasctructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var productsDto = new List<ProductDto>();

            var products = await _productRepository.GetAllAsync();

            foreach(var product in products)
            {
                productsDto.Add(
                    new ProductDto
                    {
                        Code = product.Code,
                        Name = product.Name,
                        Price = product.Price
                    });
            }

            return productsDto;
        }

        public async Task CreateAsync(int code, string name, double price) 
        {
            var product = Product.Create(code, name, price);

            await _productRepository.AddAsync(product);
        }
    }
}