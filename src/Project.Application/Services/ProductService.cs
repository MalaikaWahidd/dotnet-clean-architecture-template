using Project.Application.Interfaces;
using Project.Common.DTOs;
using Project.Domain.Interfaces.Repositories;
using Project.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _repo.GetAllAsync();

            // simple explicit mapping domain -> dto
            var dtos = products.Select(p => new ProductDto
            {
                Id = p.Id,
                CreatedAt = p.CreatedAt,
                ProductName = p.Name,
                Price = p.Price
            });

            return dtos;
        }
    }

}
