using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.SearchService.SearchHelpers
{
    public class SearchParameters : ISearchParameters
    {
        public ICollection<Type> AcceptedTypes
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<ISearchCondition> SearchConditions
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Matches(object checkedObject)
        {
            throw new NotImplementedException();
        }
    }
}
