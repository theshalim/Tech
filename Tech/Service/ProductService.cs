using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Data;
using Tech.Models;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class ProductService : IProduct
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.products.Add(product);
        }

        public void Delete(Product product)
        {
            _context.products.Remove(product);
        }

        public List<Product> GetAll()
        {
          return  _context.products.ToList();
        }

        public Product GetById(int Id)
        {
            return _context.products.Where(x=>x.Id==Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.products.Update(product);
        }
    }
}
