using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Model
{
    public sealed class Product : ModelBase
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

}
