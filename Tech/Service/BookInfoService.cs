using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;
using Tech.Data;
using Tech.Service.Interface;

namespace Tech.Service
{
    public class BookInfoService : IBookInfo
    {
        private readonly DataContext _context;
        public BookInfoService(DataContext context)
        {
            _context = context;
        }
        public void Add(BookInfo bookInfo)
        {
            _context.BookInfos.Add(bookInfo);
            _context.BookInfos.Add(bookInfo);
        }

        public void Delete(BookInfo bookInfo)
        {
            _context.BookInfos.Remove(bookInfo);
        }

        public IEnumerable<BookInfo> GetAll()
        {
            return _context.BookInfos.ToList();
        }

        public BookInfo GetById(int BookId)
        {
            return _context.BookInfos.Where(x => x.BookId == BookId).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

        public void Update(BookInfo bookInfo)
        {
            _context.BookInfos.Update(bookInfo);
        }
    }
}
