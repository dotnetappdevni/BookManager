using BookManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Tests
{
    public interface ISQLTestBase
    {
        Task<ApplicationDBContext> GetDbContext();

        void UseSqlite();


    }
}
