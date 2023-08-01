using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Data;
using Tech.Models;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class ProductUnitService : IProductUnit
    {
        private readonly DataContext _context;
        public ProductUnitService (DataContext context)
        {

        }
        public void Add(ProductUnit productUnit)
        {
            _context.productUnits.Add(productUnit);
        }

        public void Delete(ProductUnit productUnit)
        {
            _context.productUnits.Remove(productUnit);
        } 
        public List<ProductUnit> GetAll()
        {
            return _context.productUnits.ToList();
        }

        public ProductUnit GetById(int Id)
        {
            return _context.productUnits.Where(x => x.UnitId == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductUnit productUnit)
        {
            _context.productUnits.Update(productUnit);
        }
    }
}
