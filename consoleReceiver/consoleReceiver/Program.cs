using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;
using Azure.Storage.Blobs;

namespace consoleReceiver
{
    class Program
    {
        ////Event Hub
        //private const string EHConnectionString = "Endpoint=sb://iothub-ns-iotdemolus-9426885-49fb751d70.servicebus.windows.net/;SharedAccessKeyName=iothubowner;SharedAccessKey=fV8cH91Em55vGD5a/pHMe2OKu1r4/t8uMIZsxBvs+ME=;EntityPath=iotdemolusty";
        //private const string EHConsumerGroup = "windowsreceiver";
        ////Blob Account
        //private const string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=appreceiverlusty;AccountKey=34vzg/KQpijpRU08telSznlyhTUKw8w59t7xSR71z+r3WkUWGftOpw8/W5qZAMXWTgZYahzPhO3pXpDD+zgVjg==;EndpointSuffix=core.windows.net";
        //private const string blobContainerName = "receiverapp";
        //Event Hub
        private const string EHConnectionString = "Endpoint=sb://csvlusty.servicebus.windows.net/;SharedAccessKeyName=windowsreceiver;SharedAccessKey=tgfaU9MUPv28ll6ie7r8NTZLmZZUHWHnpIFSlbPvl6U=;EntityPath=csvdata";
        private const string EHConsumerGroup = "app";
        //Blob Account
        private const string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=appreceiverlusty;AccountKey=34vzg/KQpijpRU08telSznlyhTUKw8w59t7xSR71z+r3WkUWGftOpw8/W5qZAMXWTgZYahzPhO3pXpDD+zgVjg==;EndpointSuffix=core.windows.net";
        private const string blobContainerName = "receiverapp";

        static async Task Main(string[] args)
        {
            Console.WriteLine("welcome!");
            try
            {
                // Create a blob container client that the event processor will use 
                BlobContainerClient storageClient = new BlobContainerClient(blobStorageConnectionString, blobContainerName);

                // Create an event processor client to process events in the event hub
                EventProcessorClient processor = new EventProcessorClient(storageClient, EHConsumerGroup, EHConnectionString);
                // Register handlers for processing events and handling errors
                processor.ProcessEventAsync += ProcessEventHandler;
                processor.ProcessErrorAsync += ProcessErrorHandler;

                // Start the processing
                await processor.StartProcessingAsync();
                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async Task ProcessEventHandler(ProcessEventArgs eventArgs)
        {
            // Write the body of the event to the console window
            Console.WriteLine("\tReceived event: {0}", Encoding.UTF8.GetString(eventArgs.Data.Body.ToArray()));

            // Update checkpoint in the blob storage so that the app receives only new events the next time it's run
            await eventArgs.UpdateCheckpointAsync(eventArgs.CancellationToken);
        }

        static Task ProcessErrorHandler(ProcessErrorEventArgs eventArgs)
        {
            // Write details about the error to the console window
            Console.WriteLine($"\tPartition '{ eventArgs.PartitionId}': an unhandled exception was encountered. This was not expected to happen.");
            Console.WriteLine(eventArgs.Exception.Message);
            return Task.CompletedTask;
        }
    }
}
