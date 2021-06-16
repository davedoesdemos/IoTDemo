using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;
using Azure.Storage.Blobs;

namespace WindowsReceiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void appendToRichTextBox(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(appendToRichTextBox), new object[] { text });
                return;
            }
            richTextBox1.AppendText(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goTime();
        }

        private async Task goTime()
        {
            try
            {
                // Create a blob container client that the event processor will use 
                BlobContainerClient storageClient = new BlobContainerClient(textBoxStorageConnectionString.Text, textBoxBlobContainer.Text);

                // Create an event processor client to process events in the event hub
                EventProcessorClient processor = new EventProcessorClient( storageClient, textBoxConsumerGroup.Text, textBoxEHConnectionString.Text);
                // Register handlers for processing events and handling errors
                processor.ProcessEventAsync += ProcessEventHandler;
                processor.ProcessErrorAsync += ProcessErrorHandler;

                // Start the processing
                await processor.StartProcessingAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        static async Task ProcessEventHandler(ProcessEventArgs eventArgs)
        {
            // Write the body of the event to the console window
            MessageBox.Show("\tReceived event: {0}", Encoding.UTF8.GetString(eventArgs.Data.Body.ToArray()));




            // Update checkpoint in the blob storage so that the app receives only new events the next time it's run
            await eventArgs.UpdateCheckpointAsync(eventArgs.CancellationToken);
        }

        static Task ProcessErrorHandler(ProcessErrorEventArgs eventArgs)
        {
            // Write details about the error to the console window
            MessageBox.Show($"\tPartition '{ eventArgs.PartitionId}': an unhandled exception was encountered. This was not expected to happen.");
            MessageBox.Show(eventArgs.Exception.Message);
            return Task.CompletedTask;
        }

        private void textBoxEHConnectionString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
