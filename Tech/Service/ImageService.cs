using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Data;
using Tech.Migrations;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class ImageService : IImage
    {
        private readonly DataContext _context;
        public ImageService(DataContext context) {

            _context = context;
        }

        public void Add(ImageImplementation imageImplementation)
        {
            _context.ImageImplementations.Add(imageImplementation); 
        }

        public void Delete(ImageImplementation imageImplementation)
        {
            throw new NotImplementedException();
        }

        public List<ImageImplementation> GetAll()
        {
            throw new NotImplementedException();
        }

        public ImageImplementation GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ImageImplementation imageImplementation)
        {
            throw new NotImplementedException();
        }
    }
}
