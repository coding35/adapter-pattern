namespace AdapterPattern.Interface;

public interface ISMSLegacyProvider
{
    void SendSMS(string phoneNumber, string message);
    void SendSMS(string phoneNumber, string message, string sender);
}