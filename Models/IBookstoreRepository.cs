using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBookstoreRepository
    {
        // no set so that we can only get data from database
        IQueryable<Book> Books { get; }
    }
}
