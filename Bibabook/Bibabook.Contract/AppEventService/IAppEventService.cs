using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody związane z obsługą wydarzenia.
    /// </summary>
    public interface IAppEventService
    {
        /// <summary>
        /// Dodaje wydarzenia do bazy danych.
        /// </summary>
        /// <param name="appEvent">Wydarzenie, które należy umieścić w bazie.</param>
        /// <returns></returns>
        Boolean Create(IAppEvent appEvent);

        /// <summary>
        /// Odwołuje wydarzenie. Powinno zostać oznaczone w bazie jako nieaktywne. Wszyscy przypisani 
        /// użytkownicy powinni otrzymać stosowne powiadomienie (notyfikację). Opcja ta dostępna powinna 
        /// być wyłącznie dla twórcy wydarzenia.
        /// </summary>
        /// <param name="appEvent">Instancja odwoływanego wydarzenia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Cancel(IAppEvent appEvent);

        /// <summary>
        /// Kasuje wydarzenie (np. z powodu naruszenia). Powinno zostać ono usunięte z bazy. Wszystkie 
        /// przypisane do niego posty powinny zostać skasowane. Wszyscy przypisani użytkownicy powinni 
        /// otrzymać stosowne powiadomienie (notyfikację). Opcja ta dostępna powinna być wyłącznie 
        /// dla moderatorów.
        /// </summary>
        /// <param name="appEvent">Instancja odwoływanego wydarzenia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Delete(IAppEvent appEvent);

        /// <summary>
        /// Zaprasza użytkownika na wydarzenie. Użytkownik powinien otrzymać stosowne powiadomienie.
        /// </summary>
        /// <param name="appEvent">Instancja wydarzenia</param>
        /// <param name="sender">Użytkownik zapraszający</param>
        /// <param name="recipient">Adresat zaproszenia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean InviteUser(IAppEvent appEvent, IAppUser sender, IAppUser recipient);

        /// <summary>
        /// Zaprasza użytkowników na wydarzenie. Użytkownicy powinni otrzymać stosowne powiadomienia.
        /// </summary>
        /// <param name="appEvent">Instancja wydarzenia</param>
        /// <param name="sender">Użytkownik zapraszający</param>
        /// <param name="recipients">Adresaci zaproszenia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean InviteUser(IAppUser appEvent, IAppUser sender, ICollection<IAppUser> recipients);

        /// <summary>
        /// Zapisuje użytkownika na wydarzenie.
        /// </summary>
        /// <param name="appEvent">Instancja wydarzenia</param>
        /// <param name="appUser">Zapisywany użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean EnrollUser(IAppUser appEvent, IAppUser appUser);

        /// <summary>
        /// Wypisuje użytkownika z wydarzenia. Użytkownik może wypisać się sam, może zostać wyproszony przez
        /// właściciela wydarzenia lub przez moderatorów.
        /// </summary>
        /// <param name="appEvent">Instancja wydarzenia</param>
        /// <param name="appUser">Wypisywany użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean RemoveUser(IAppEvent appEvent, IAppUser appUser);

        /// <summary>
        /// Wypisuje użytkowników z wydarzenia.
        /// </summary>
        /// <param name="appEvent">Instancja wydarzenia</param>
        /// <param name="appUsers">Wypisywany użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean RemoveUser(IAppEvent appEvent, ICollection<IAppUser> appUsers);

        /// <summary>
        /// Nakłada zakaz partycypacji użytkownika w wydarzeniu. Dodaje użytkownika do listy użytkowników, 
        /// którzy nie mogą zapisać się na wydarzenie. Opcja ta dostępna powinna być wyłącznie dla twórcy 
        /// wydarzenia.
        /// </summary>
        /// <param name="appEvent">Wydarzenie</param>
        /// <param name="appUsers">Użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean ForbidUser(IAppEvent appEvent, IAppUser appUser); 

        /// <summary>
        /// Anuluje zakaz partycypacji użytkownika w wydarzeniu. Opcja ta dostępna powinna być wyłącznie 
        /// dla twórcy wydarzenia.
        /// </summary>
        /// <param name="appEvent">Wydarzenie</param>
        /// <param name="appUsers">Użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean AllowUser(IAppEvent appEvent, IAppUser appUser);

        /// <summary>
        /// Przypisuje post do wydarzenia.
        /// </summary>
        /// <param name="appEvent">Wydarzenie</param>
        /// <param name="eventPost">Przypisywany post</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean AddEventPost(IAppEvent appEvent, IEventPost eventPost);

        // + Dodać metody związane ze zmianą parametrów.
    }
}