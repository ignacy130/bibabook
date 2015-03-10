using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Określa parametry wyszukiwania.
    /// </summary>
    public interface ISearchParameters
    {
        /// <summary>
        /// Typy, które będą brane pod uwagę w trakcie wyszukiwania
        /// </summary>
        ICollection<Type> AcceptedTypes { get; set; }

        /// <summary>
        /// Warunki, które będą brane pod uwagę w trakcie wyszukiwania
        /// </summary>
        IList<ISearchCondition> SearchConditions { get; set; }

        /// <summary>
        /// Określa czy dany obiekt spełnia zadane warunki.
        /// </summary>
        /// <param name="checkedObject">Badany obiekt</param>
        /// <returns>Prawda jeśli badany obiekt jest akceptowanego typu oraz spełnia wszystkie warunki. 
        /// Fałsz w przeciwnym przypadku.</returns>
        Boolean Matches(Object checkedObject);
    }
}