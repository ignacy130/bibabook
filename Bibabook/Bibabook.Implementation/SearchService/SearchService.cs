using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.SearchService
{
    public class SearchService : ISearchService
    {
        public ICollection<ISearchable> Search(IEnumerable<string> tags)
        {
            throw new NotImplementedException();
        }
    }
}
