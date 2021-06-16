using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTDemo
{
    public partial class MainIoTForm : Form
    {
        class transaction
        {
            public string productName;
            public decimal productPrice;
            public int productSKU;
            public int quantity;
            public DateTime timestamp;
        }

        private static DeviceClient s_deviceClient;
        public MainIoTForm()
        {
            InitializeComponent();
        }


        // Async method to send simulated telemetry
        private static async void SendDeviceToCloudMessagesAsync(transaction transactionData)
        {
            //Convert the data to JSON and serialise
            var messageString = JsonConvert.SerializeObject(transactionData);
            var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageString));

            // Send the telemetry message
            await s_deviceClient.SendEventAsync(message);
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            transaction transactionData = new transaction();

            //get the button details
            Button clickedButton = (Button)sender;

            //set up data based on the button
            switch (clickedButton.Name)
            {
                case "buttonShop1":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 1.34M;
                    transactionData.productSKU = 1;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop2":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 0.67M;
                    transactionData.productSKU = 2;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop3":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 65.28M;
                    transactionData.productSKU = 3;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop4":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 0.99M;
                    transactionData.productSKU = 4;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop5":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 2.76M;
                    transactionData.productSKU = 5;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop6":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 2.32M;
                    transactionData.productSKU = 6;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                case "buttonShop7":
                    richTextBox1.AppendText(clickedButton.Text + '\n');
                    transactionData.productName = clickedButton.Text;
                    transactionData.productPrice = 1.66M;
                    transactionData.productSKU = 7;
                    transactionData.quantity = 1;
                    transactionData.timestamp = DateTime.Now;
                    break;
                default:
                    richTextBox1.AppendText("Something went wrong in the switch");
                    break;
            }
            if (s_deviceClient != null)
            {
                SendDeviceToCloudMessagesAsync(transactionData);
            } else
            {
                richTextBox1.AppendText("IoT is not configured");
            }
        }

        private void textBoxConnectionString_TextChanged(object sender, EventArgs e)
        {
            s_deviceClient = DeviceClient.CreateFromConnectionString(textBoxConnectionString.Text, TransportType.Mqtt);
        }
    }
}
