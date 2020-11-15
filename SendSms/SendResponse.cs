namespace SendSms
{
    public class SendResponse
    {
        public ResponseStatus Status { get; set; }

        public string Description { get; set; }

        public string MessageId { get; set; }

        public string DeliveryStatusUrl { get; set; }

    }
}