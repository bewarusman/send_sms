namespace SendSms
{
    public enum ResponseStatus : int
    {
        NotProvidedApiKey = -100,
        InvalidApiKey = -99,
        InvalidSm = -98,
        TooLongSm = -97,
        InActiveChannel = -96,
        NotAuthorizedIp = -95,
        SubmitSmNotFound = -94,
        DeliveryNotKnown = -93,
        ThresholdLimitReached = -92,
        InternalError = -1,
        Success = 0,

        InProgress = 2,
        Submitted = 3,
        Failed = 4
    }
}