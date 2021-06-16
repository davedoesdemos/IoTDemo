
namespace WindowsReceiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEHConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConsumerGroup = new System.Windows.Forms.TextBox();
            this.textBoxEventHubName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStorageConnectionString = new System.Windows.Forms.TextBox();
            this.textBoxBlobContainer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(258, 256);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1558, 430);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(1831, 15);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(158, 87);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Hub Connection String";
            // 
            // textBoxEHConnectionString
            // 
            this.textBoxEHConnectionString.Location = new System.Drawing.Point(258, 6);
            this.textBoxEHConnectionString.Name = "textBoxEHConnectionString";
            this.textBoxEHConnectionString.Size = new System.Drawing.Size(1558, 31);
            this.textBoxEHConnectionString.TabIndex = 3;
            this.textBoxEHConnectionString.Text = "Endpoint=sb://iothub-ns-iotdemolus-9426885-49fb751d70.servicebus.windows.net/;Sha" +
    "redAccessKeyName=iothubowner;SharedAccessKey=fV8cH91Em55vGD5a/pHMe2OKu1r4/t8uMIZ" +
    "sxBvs+ME=;EntityPath=iotdemolusty";
            this.textBoxEHConnectionString.TextChanged += new System.EventHandler(this.textBoxEHConnectionString_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event Hub Name";
            // 
            // textBoxConsumerGroup
            // 
            this.textBoxConsumerGroup.Location = new System.Drawing.Point(258, 80);
            this.textBoxConsumerGroup.Name = "textBoxConsumerGroup";
            this.textBoxConsumerGroup.Size = new System.Drawing.Size(1558, 31);
            this.textBoxConsumerGroup.TabIndex = 7;
            this.textBoxConsumerGroup.Text = "windowsreceiver";
            // 
            // textBoxEventHubName
            // 
            this.textBoxEventHubName.Location = new System.Drawing.Point(258, 43);
            this.textBoxEventHubName.Name = "textBoxEventHubName";
            this.textBoxEventHubName.Size = new System.Drawing.Size(1558, 31);
            this.textBoxEventHubName.TabIndex = 9;
            this.textBoxEventHubName.Text = "iothub-ns-iotdemolus-9426885-49fb751d70";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Consumer Group";
            // 
            // textBoxStorageConnectionString
            // 
            this.textBoxStorageConnectionString.Location = new System.Drawing.Point(258, 117);
            this.textBoxStorageConnectionString.Name = "textBoxStorageConnectionString";
            this.textBoxStorageConnectionString.Size = new System.Drawing.Size(1558, 31);
            this.textBoxStorageConnectionString.TabIndex = 10;
            this.textBoxStorageConnectionString.Text = "DefaultEndpointsProtocol=https;AccountName=appreceiverlusty;AccountKey=34vzg/KQpi" +
    "jpRU08telSznlyhTUKw8w59t7xSR71z+r3WkUWGftOpw8/W5qZAMXWTgZYahzPhO3pXpDD+zgVjg==;E" +
    "ndpointSuffix=core.windows.net";
            // 
            // textBoxBlobContainer
            // 
            this.textBoxBlobContainer.Location = new System.Drawing.Point(258, 154);
            this.textBoxBlobContainer.Name = "textBoxBlobContainer";
            this.textBoxBlobContainer.Size = new System.Drawing.Size(1558, 31);
            this.textBoxBlobContainer.TabIndex = 11;
            this.textBoxBlobContainer.Text = "receiverapp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Storage Connection String";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Blob Container";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2004, 699);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBlobContainer);
            this.Controls.Add(this.textBoxStorageConnectionString);
            this.Controls.Add(this.textBoxEventHubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConsumerGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEHConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEHConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConsumerGroup;
        private System.Windows.Forms.TextBox textBoxEventHubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStorageConnectionString;
        private System.Windows.Forms.TextBox textBoxBlobContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

