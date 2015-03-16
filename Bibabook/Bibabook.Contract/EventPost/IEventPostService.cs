using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody do zarządzania postami.
    /// </summary>
    public interface IEventPostService
    {
        /// <summary>
        /// Dodaje nowy post do bazy.
        /// </summary>
        /// <param name="eventPost">Dodawany post</param>
        /// <returns>Prawda jeśli wszystko prz ebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Create(IEventPost eventPost);

        /// <summary>
        /// Zmienia treść posta. Opcja ta powinna być dostepna wyłącznie dla autora posta oraz moderatorów.
        /// </summary>
        /// <param name="eventPost">Instancja posta</param>
        /// <param name="newContent">Nowa treść posta</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Edit(IEventPost eventPost, String newContent);

        /// <summary>
        /// Przypisuje komentarz do posta.
        /// </summary>
        /// <param name="eventPost">Instancja posta</param>
        /// <param name="postComment">Instancja komentarza</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean AddPostComment(IEventPost eventPost, IPostComment postComment);

        /// <summary>
        /// Trwale kasuje post z bazy danych. Wszystkie przypisane do niego komentarze także powinny zostać 
        /// skasowane. Opcja ta powinna być dostepna wyłącznie dla autora posta, właściciela wydarzenia
        /// oraz moderatorów.
        /// </summary>
        /// <param name="eventPost">Instancja posta do skasowania</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Delete(IEventPost eventPost);
    }
}