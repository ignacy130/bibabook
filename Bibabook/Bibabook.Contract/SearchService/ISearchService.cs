using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody wyszukiwania obiektów w bazie.
    /// </summary>
    public interface ISearchService
    {
        /// <summary>
        /// Przeszukuje całą bazę danych pod kątem zgodności tagów.
        /// </summary>
        /// <param name="tags">Zbiór tagów, na podstawie których zostanie przeszukana baza danych</param>
        /// <returns>Kolekcja obiektów bazy</returns>
        ICollection<ISearchable> Search(IEnumerable<String> tags);
    }
}