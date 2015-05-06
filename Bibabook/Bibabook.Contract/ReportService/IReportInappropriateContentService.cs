using System;

namespace Contract
{
    /// <summary>
    /// Wysyła e-maile do administacji związane z naruszeniami.
    /// </summary>
    public interface IReportInappropriateContentService
    {
        /// <summary>
        /// Zgłasza wydarzenie. Administrator otrzymuje e-mail, że użytkownik zgłosił wydarzenie z określonego powodu.
        /// </summary>
        /// <param name="userReporting">Użytkownik zgłaszający</param>
        /// <param name="eventReported">Zgłoszone wydarzenie</param>
        /// <param name="reason">Powód zgłoszenia</param>
        void ReportEvent(IAppUser userReporting, IAppEvent eventReported, ReportReason reason);

        /// <summary>
        /// Zgłasza post. Administrator otrzymuje e-mail, że użytkownik zgłosił post z określonego powodu.
        /// </summary>
        /// <param name="userReporting">Użytkownik zgłaszający</param>
        /// <param name="postReported">Zgłoszony post</param>
        /// <param name="reason">Powód zgłoszenia</param>
        void ReportPost(IAppUser userReporting, IEventPost postReported, ReportReason reason);

        /// <summary>
        /// Zgłasza komentarz. Administrator otrzymuje e-mail, że użytkownik zgłosił komentarz z określonego powodu.
        /// </summary>
        /// <param name="userReporting">Użytkownik zgłaszający</param>
        /// <param name="postReported">Zgłoszony komentarz</param>
        /// <param name="reason">Powód zgłoszenia</param>
        void ReportComment(IAppUser userReporting, IPostComment postComment, ReportReason reason);
    }
}