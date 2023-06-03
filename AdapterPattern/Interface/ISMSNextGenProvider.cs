namespace AdapterPattern.Interface;

public interface ISMSNextGenProvider
{
    void SendSMS(string message, string phoneNumber);
    void SendSMS(string message, string phoneNumber, string sender);
}