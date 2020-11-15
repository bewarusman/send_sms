namespace SendSms
{
    public class SendRequest
    {
        /// <summary>
        /// The source address [sender_id]
        /// </summary>
        public string SourceAddr { get; set; }

        /// <summary>
        /// The destination which should receive the SMS
        /// </summary>
        public string DestAddr { get; set; }

        /// <summary>
        /// The content of the SMS
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        /// Either unicode which counts 70 characters as one SMS
        /// Or ASCI code which counts 140 characters as one SMS
        /// </summary>
        public bool Unicode { get; set; }

    }
}