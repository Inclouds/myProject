using System.Collections.Generic;

namespace WebSinglePageTest.Repositories
{
    public interface IRepository<TSource>
    {
        IEnumerable<TSource> Get();
    }
}