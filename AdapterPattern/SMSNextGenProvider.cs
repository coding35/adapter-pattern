using AdapterPattern.Interface;

namespace AdapterPattern;

public class SMSNextGenProvider : ISMSNextGenProvider
{
    public void SendSMS(string message, string phoneNumber)
    {
        Console.WriteLine($"Sending SMS via NextGen provider: {message} {phoneNumber}");
    }

    public void SendSMS(string message, string phoneNumber, string sender)
    {
        Console.WriteLine($"Sending SMS via NextGen provider: {message} {phoneNumber} {sender}");
    }
}