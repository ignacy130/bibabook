namespace Contract.Enums
{
    /// <summary>
    /// Status powiadomienia
    /// </summary>
    public enum NotificationStatus
    {
        Indeterminate,
        Active,
        Inactive
    }

    /// <summary>
    /// Plec uzytkownika.
    /// </summary>
    public enum Sex
    {
        Male,
        Female
    }

    /// <summary>
    /// Status powiadomienia wydarzenia.
    /// </summary>
    enum Event
    {
        Invitation,
        Canceled,
        Changed,
        NewPost,
        PostReply,
    }

    /// <summary>
    /// Status zaproszenia do grona znajomych.
    /// </summary>
    enum Friend
    {
        Invitation,
        InvitationConfirmed,
    }

    /// <summary>
    /// Powód zgłoszenia
    /// </summary>
    public enum ReportReason
    {
        Discrimination,
        IllegalSubstances,
        IllegalActivity,
        Gore,
        Pornography,
        InnapropiateAgeCategory,
        Other
    }

    /// <summary>
    /// Typ sprawdzania warunku
    /// </summary>
    public enum SearchConditionType
    {
        Equals,
        NotEquals,
        Greater,
        Less,
        GreaterOrEqual,
        LessOrEqual,
        Contains
    }

    /// <summary>
    /// Widoczność zdarzenia
    /// </summary>
    public enum Privacy
    {
        Private,
        Public
    }
        

}