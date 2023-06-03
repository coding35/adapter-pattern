using AdapterPattern.Interface;

namespace AdapterPattern;

public class SMSLegacyProvider : ISMSLegacyProvider
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS via Legacy provider: {phoneNumber} {message}");
    }

    public void SendSMS(string phoneNumber, string message, string sender)
    {
        Console.WriteLine($"Sending SMS via Legacy provider: {phoneNumber} {message} {sender}");
    }
}