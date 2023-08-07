using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;
using Tech.Data;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class AuthorInfoService : IAuthorInfo
    {
        private readonly DataContext _context;
        public AuthorInfoService(DataContext context)
        {
            _context = context;
        }
        public void Add(AuthorInfo authorInfo)
        {
            _context.AuthorInfos.Add(authorInfo);
        }

        public void Delete(AuthorInfo authorInfo)
        {
            _context.AuthorInfos.Remove(authorInfo);
        }

        public IEnumerable<AuthorInfo> GetAll()
        {
            return _context.AuthorInfos.ToList();
         
        }

        public AuthorInfo GetById(int AuthorId)
        {
            return _context.AuthorInfos.Where(x => x.AuthorId == AuthorId).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

        public void Update(AuthorInfo authorInfo)
        {
            _context.AuthorInfos.Update(authorInfo);
        }
    }
}
