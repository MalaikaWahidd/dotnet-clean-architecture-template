using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; init; }
        public DateTime CreatedAt { get; init; }
        public string ProductName { get; init; } = string.Empty;
        public decimal Price { get; init; }
    }

}
