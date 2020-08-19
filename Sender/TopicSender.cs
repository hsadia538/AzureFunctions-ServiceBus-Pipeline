using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Azure.WebJobs.Host;
using System.Text;
using System.Net;

namespace Sender
{
    public static class TopicSender
    {
        [FunctionName("TopicSender")]
        
        [return: ServiceBus("praticetopics","sub1", Connection = "ServiceBusConnection")]
        public static string ServiceBusOutput([HttpTrigger] dynamic input, ILogger log)
        {
            log.LogInformation($"C# Messege sent: {input.Text}");
            return input.Text;
        }
    }
}
