using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody do zarządzania postami.
    /// </summary>
    public interface IEventPostService
    {
        Boolean Create(/* argumenty ściśle zależą od przyjętego modelu posta */);

        /// <summary>
        /// Zmienia treść posta. Opcja ta powinna być dostepna wyłącznie dla autora posta oraz moderatorów.
        /// </summary>
        /// <param name="eventPostId">Unikalny identyfikator (GUID) posta</param>
        /// <param name="newContent">Nowa treść posta</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Edit(IEventPost post, String newContent);

        /// <summary>
        /// Przypisuje komentarz do posta.
        /// </summary>
        /// <param name="eventPostId">Unikalny identyfikator (GUID) posta</param>
        /// <param name="postCommentId">Unikalny identyfikator (GUID) komentarza</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean AddPostComment(IEventPost eventPostId, IPostComment postCommentId);

        /// <summary>
        /// Trwale kasuje post z bazy danych. Wszystkie przypisane do niego komentarze także powinny zostać 
        /// skasowane. Opcja ta powinna być dostepna wyłącznie dla autora posta, właściciela wydarzenia
        /// oraz moderatorów.
        /// </summary>
        /// <param name="eventPost">Instancja posta do skasowania</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Delete(IEventPost eventPost);
    }
}