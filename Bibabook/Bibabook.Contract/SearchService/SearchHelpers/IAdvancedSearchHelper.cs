using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia zaawansowane metody wyszukiwania obiektów na podstawie specjalnych warunków wyszukiwania.
    /// </summary>
    public interface IAdvancedSearchHelper
    {
        /// <summary>
        /// Metoda wyszukująca w bazie użytkowników przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters">Parametry wyszukiwania</param>
        /// <returns></returns>
        ICollection<IAppUser> SearchUsers(ISearchParameters searchParameters);

        /// <summary>
        /// Metoda wyszukująca w bazie wydarzeń przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ICollection<IAppEvent> SearchEvents(ISearchParameters searchParameters);

        /// <summary>
        /// Metoda wyszukująca w bazie powiadomień przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ICollection<INotification> SearchNotifications(ISearchParameters searchParameters);
    }
}