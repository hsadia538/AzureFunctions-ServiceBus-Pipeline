using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace RecieveFromTopic
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("practicetopic", "sub1", Connection = "MyServiceBus")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
