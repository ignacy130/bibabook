using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody do zarządzania komentarzami.
    /// </summary>
    public interface IPostCommentService
    {
        Boolean Create(/* argumenty ściśle zależą od przyjętego modelu komentarza */);

        /// <summary>
        /// Zmienia treść komentarza. Opcja ta powinna być dostepna wyłącznie dla autora komentarza oraz moderatorów.
        /// </summary>
        /// <param name="postCommentId">Unikalny identyfikator (GUID) komentarza</param>
        /// <param name="newContent">Nowa treść komentarza</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Edit(String postCommentId, String newContent);

        /// <summary>
        /// Trwale kasuje komentarz z bazy danych. Opcja ta powinna być dostepna wyłącznie dla autora, właściciela 
        /// wydarzenia oraz moderatorów.
        /// </summary>
        /// <param name="postComment">Instancja komentarza do skasowania</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Delete(IPostComment postComment);
    }
}