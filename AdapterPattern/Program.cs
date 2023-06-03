// See https://aka.ms/new-console-template for more information

using AdapterPattern;
using AdapterPattern.Interface;

SMSLegacyProvider smsLegacyProvider = new SMSLegacyProvider();


SMSNextGenProvider smsNextGenProvider = new SMSNextGenProvider();
var smsNextGenAdapter = new SMSAdapter(smsNextGenProvider);

TestProvider(smsLegacyProvider);
TestProvider(smsNextGenAdapter);

static void TestProvider(ISMSLegacyProvider provider)
{
    provider.SendSMS("1234567890", "Hello World");
}