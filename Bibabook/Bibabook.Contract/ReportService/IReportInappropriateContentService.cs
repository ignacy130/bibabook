using System;

namespace Contract
{
    public enum ReportReason
    {
        Discrimination,
        IllegalSubstances,
        IllegalActivity,
        Gore,
        Pornography,
        InnapropiateAgeCategory
    }

    /// <summary>
    /// Wysyła e-maile do administacji związane z naruszeniami.
    /// </summary>
    public interface IReportInappropriateContentService
    {
        /// <summary>
        /// Zgłasza wydarzenie. Administrator otrzymuje e-mail, że użytkownik zgłosił wydarzenie z określonego powodu.
        /// </summary>
        /// <param name="userReporting">User initiating report.</param>
        /// <param name="eventReported">Event to report.</param>
        /// <param name="reason">Reason of report.</param>
        void ReportEvent(IAppEvent userReporting, IAppEvent eventReported, ReportReason reason);

        /// <summary>
        /// Zgłasza post. Administrator otrzymuje e-mail, że użytkownik zgłosił post z określonego powodu.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator zgłaszającego (GUID)</param>
        /// <param name="appUserName">Nazwa zgłaszającego</param>
        /// <param name="eventPostId">Unikalny identyfikator posta (GUID)</param>
        /// <param name="reason">Powód zgłoszenia</param>
        void ReportPost(String appUserId, String appUserName, String eventPostId, String reason);

        /// <summary>
        /// Zgłasza komentarz. Administrator otrzymuje e-mail, że użytkownik zgłosił komentarz z określonego powodu.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator zgłaszającego (GUID)</param>
        /// <param name="appUserName">Nazwa zgłaszającego</param>
        /// <param name="postCommentId">Unikalny identyfikator komentarza (GUID)</param>
        /// <param name="reason">Powód zgłoszenia</param>
        void ReportComment(String appUserId, String appUserName, String postCommentId, String reason);
    }
}