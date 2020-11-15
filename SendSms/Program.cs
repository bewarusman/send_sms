using System;

namespace SendSms
{
    class Program
    {
        static void Main(string[] args)
        {
            var sendRequest = new SendRequest
            {
                SourceAddr = "Kurtename",
                DestAddr = "9647504958807",
                MessageText = "Test SMS",
                Unicode = false
            };
            Console.WriteLine("SOURCE: {0} | DESTINATION: {1} | TEXT: {2} | UNICODE: {3}", sendRequest.SourceAddr, sendRequest.DestAddr, sendRequest.MessageText, sendRequest.Unicode);

            var sendService = new SendService();
            var sendResponse = sendService.Submit(sendRequest).Result;

            Console.WriteLine("STATUS: {0} | DESCRIPTION: {1} | MESSAGE_ID: {2}", sendResponse.Status, sendResponse.Description, sendResponse.MessageId);
        }
    }
}