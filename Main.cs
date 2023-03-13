using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordPing
{
    public partial class Main : Form
    {
        private bool sendingEnabled = false;
        private int sendDelay = 1000; // default to 1 second delay

        public Main()
        {
            InitializeComponent();
            this.delaySlider.ValueChanged += new System.EventHandler(this.delaySlider_ValueChanged);
            this.webhookUrlTextBox.TextChanged += new System.EventHandler(this.webhookUrlTextBox_TextChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel1.BorderRadius = 20;
            sendButton.BorderRadius = 6;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // Get the message and webhook URL from their respective text boxes
            string message = messageTextBox.Text.Trim();
            string webhookUrl = webhookUrlTextBox.Text.Trim();

            // Check if the webhook URL is empty or false
            if (string.IsNullOrEmpty(webhookUrl) || webhookUrl.ToLower() == "false")
            {
                // If the webhook URL is empty or false, log an error message and return
                AddLogMessage("Webhook URL is missing or invalid.");
                return;
            }

            // Create a new HttpClient object
            HttpClient client = new HttpClient();

            // Create a new StringContent object with the message data
            StringContent content = new StringContent("{\"content\":\"" + message + "\"}", Encoding.UTF8, "application/json");
            content.Headers.ContentType.CharSet = "utf-8";


            try
            {
                // Post the message data to the webhook URL
                HttpResponseMessage response = client.PostAsync(webhookUrl, content).Result;

                // Check the response status code to see if the message was successfully sent
                if (response.IsSuccessStatusCode)
                {
                    // If the message was sent successfully, log a success message
                    AddLogMessage("Message sent successfully.");
                }
                else
                {
                    // If there was an error sending the message, log an error message
                    AddLogMessage("Error sending message: " + response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                // If there was an exception, log an error message
                AddLogMessage("Error sending message: " + ex.Message);
            }
        }


        private void AddLogMessage(string message)
        {
            if (logTextBox.InvokeRequired)
            {
                // If the call is not coming from the main thread, marshal the call to the main thread
                logTextBox.Invoke(new Action<string>(AddLogMessage), message);
            }
            else
            {
                // If the call is coming from the main thread, update the log text box
                logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + " - " + message + "\r\n");
            }
        }


        private void webhookUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the webhook URL text box is empty or false, disable the send button
            if (string.IsNullOrEmpty(webhookUrlTextBox.Text.Trim()) || webhookUrlTextBox.Text.Trim().ToLower() == "false")
            {
                sendButton.Enabled = false;
            }
            else
            {
                sendButton.Enabled = true;
            }
        }

        private void delaySlider_ValueChanged(object sender, EventArgs e)
        {
            // Get the value of the delay slider and set the text of the delay label to the value in milliseconds
            delayLabel.Text = $"{delaySlider.Value} ms";
            sendDelay = delaySlider.Value;
        }

        
        private Thread sendingThread = null;

        private void enableSendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sendingEnabled = enableSendingCheckBox.Checked;
            if (sendingEnabled)
            {
                // Start a new thread to send messages at the specified interval
                sendingThread = new Thread(new ThreadStart(SendingThreadFunction));
                sendingThread.Start();
            }
            else
            {
                // Stop the sending thread
                sendingThread?.Abort();
                sendingThread = null;
            }
        }



        private void SendingThreadFunction()
        {
            while (sendingEnabled)
            {
                // Send the message
                sendButton_Click(this, EventArgs.Empty);

                // Sleep for the specified delay
                Thread.Sleep(sendDelay);
            }
        }
    }
}