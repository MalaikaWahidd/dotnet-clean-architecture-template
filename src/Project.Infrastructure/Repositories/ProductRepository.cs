using Project.Domain.Interfaces.Repositories;
using Project.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> _products =
        [
            new Product { Name = "Keyboard", Price = 299000 },
            new Product { Name = "Gaming Mouse", Price = 499000 }
        ];

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult(_products.AsEnumerable());
        }
    }

}
