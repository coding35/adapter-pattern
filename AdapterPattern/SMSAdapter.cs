using AdapterPattern.Interface;

namespace AdapterPattern;


/// <summary>
/// The legacy SMS provider is adapted to the new SMS provider. The adaptation is the ordering of the parameters.
/// </summary>
public class SMSAdapter : ISMSLegacyProvider
{
    readonly ISMSNextGenProvider _smsNextGenProvider;

    public SMSAdapter(ISMSNextGenProvider smsNextGenProvider)
    {
        _smsNextGenProvider = smsNextGenProvider;
    }
    public void SendSMS(string phoneNumber, string message)
    {
        _smsNextGenProvider.SendSMS(message, phoneNumber);
    }

    public void SendSMS(string phoneNumber, string message, string sender)
    {
        _smsNextGenProvider.SendSMS(message, phoneNumber, sender);
    }
}