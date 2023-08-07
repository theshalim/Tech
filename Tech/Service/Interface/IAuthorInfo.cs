using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech.Models;

namespace Tech.Service.Interface
{
    interface IAuthorInfo
    {
        IEnumerable<AuthorInfo> GetAll();
        AuthorInfo GetById(int AuthorId);
        void Add(AuthorInfo authorInfo);
        void Delete(AuthorInfo authorInfo);
        void Update(AuthorInfo authorInfo);
        void Save();
    }
}
