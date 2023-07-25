using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;

namespace Tech.Service.Interface
{
    interface IPriceRange
    {
        List<PriceRange> GetAll();
        PriceRange GetById(int PriceRangeId);
        void Add(PriceRange priceRange);
        void Delete(PriceRange priceRange);
        void Update(PriceRange priceRange);
        void Save();

    }
}
