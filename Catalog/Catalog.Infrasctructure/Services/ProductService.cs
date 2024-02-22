using AutoMapper;
using Catalog.Core.Domain;
using Catalog.Core.Repositories;
using Catalog.Infrasctructure.DTO;
using System.Collections;

namespace Catalog.Infrasctructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        }

        public async Task CreateAsync(int code, string name, double price) 
        {
            var product = Product.Create(code, name, price);

            await _productRepository.AddAsync(product);
        }
    }
}