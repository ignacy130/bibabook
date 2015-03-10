using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody do zarządzania komentarzami.
    /// </summary>
    public interface IPostCommentService
    {
        /// <summary>
        /// Dodaje komentarz do bazy.
        /// </summary>
        /// <param name="eventPost">Dodawany komentarz</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Create(IPostComment postComment);

        /// <summary>
        /// Zmienia treść komentarza. Opcja ta powinna być dostepna wyłącznie dla autora komentarza oraz moderatorów.
        /// </summary>
        /// <param name="postComment">Komentarz</param>
        /// <param name="newContent">Nowa treść komentarza</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Edit(IPostComment postComment, String newContent);

        /// <summary>
        /// Trwale kasuje komentarz z bazy danych. Opcja ta powinna być dostepna wyłącznie dla autora, właściciela 
        /// wydarzenia oraz moderatorów.
        /// </summary>
        /// <param name="postComment">Instancja komentarza do skasowania</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Delete(IPostComment postComment);
    }
}