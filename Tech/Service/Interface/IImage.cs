using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Migrations;

namespace Tech.Service.Interface
{
    interface IImage
    {
        List<ImageImplementation> GetAll();
        ImageImplementation GetById(int Id);
        void Add(ImageImplementation imageImplementation);
        void Delete(ImageImplementation imageImplementation);
        void Update(ImageImplementation imageImplementation);
        void Save();
    }
}
