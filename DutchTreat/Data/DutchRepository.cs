using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _dutchContext;

        public DutchRepository(DutchContext dutchContext)
        {
            _dutchContext = dutchContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dutchContext.Products.OrderBy(p => p.Title).ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _dutchContext.Products.Where(p => p.Category == category).ToList();
        }

        public bool SaveAll()
        {
            return _dutchContext.SaveChanges() > 0;
        }
    }
}
