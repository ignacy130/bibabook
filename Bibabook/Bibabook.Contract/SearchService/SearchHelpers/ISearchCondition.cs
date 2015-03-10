using System;

namespace Contract
{
    /// <summary>
    /// Określa warunek wyszukiwania.
    /// Np. 
    ///     PropertyName = "Imie", ValueSeeked = "Anna", ConditionType = SearchConditionType.Contains
    ///     PropertyName = "Wiek", ValueSeeked = "26", ConditionType = SearchConditionType.GreaterOrEqual
    /// </summary>
    public interface ISearchCondition
    {
        /// <summary>
        /// Nazwa pola, w którym rozważać będzie się szukaną wartość
        /// </summary>
        String PropertyName { get; set; }

        /// <summary>
        /// Wartość, do której odniesienia szukamy
        /// </summary>
        Object ValueSeeked { get; set; }

        /// <summary>
        /// Sposób porównania pola z zadaną wartością (np. równy, zawiera, większy)
        /// </summary>
        SearchConditionType ConditionType { get; set; }
    }
}
