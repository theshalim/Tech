using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;

namespace Tech.Service.Interface
{
    interface IProductUnit
    {
        List<ProductUnit> GetAll();
        ProductUnit GetById(int Id);
        void Add(ProductUnit productUnit);
        void Delete(ProductUnit productUnit);
        void Update(ProductUnit productUnit);
        void Save();
    }
}
