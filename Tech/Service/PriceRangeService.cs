using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Data;
using Tech.Models;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class PriceRangeService : IPriceRange
    {
        private readonly DataContext _context;
        public PriceRangeService(DataContext context)
        {
            _context = context;
        }
        public void Add(PriceRange priceRange)
        {
            _context.priceRanges.Add(priceRange);
        }

        public void Delete(PriceRange priceRange)
        {
            _context.priceRanges.Remove(priceRange);
        }

        public List<PriceRange> GetAll()
        {
            return _context.priceRanges.ToList();
        }

        public PriceRange GetById(int PriceRangeId)
        {
            return _context.priceRanges.Where(x => x.PriceRangeId == PriceRangeId).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(PriceRange priceRange)
        {
            _context.priceRanges.Update(priceRange);
        }
    }
}
