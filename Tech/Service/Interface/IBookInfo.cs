using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;

namespace Tech.Service.Interface
{
    interface IBookInfo
    {
        IEnumerable<BookInfo> GetAll();
        BookInfo GetById(int BookId);
        void Add(BookInfo bookInfo);
        void Delete(BookInfo bookInfo);
        void Update(BookInfo bookInfo);
        void Save();
    }
}
