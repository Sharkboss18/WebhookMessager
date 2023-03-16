namespace DiscordPing
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendButton = new Guna.UI2.WinForms.Guna2Button();
            this.webhookUrlTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.delaySlider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.delayLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.enableSendingCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.logTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.nicknameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Animated = true;
            this.messageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTextBox.DefaultText = "";
            this.messageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.messageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.messageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.messageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTextBox.Location = new System.Drawing.Point(109, 22);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.PlaceholderText = "Message";
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.Size = new System.Drawing.Size(200, 36);
            this.messageTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Animated = true;
            this.sendButton.AutoRoundedCorners = true;
            this.sendButton.BorderRadius = 14;
            this.sendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(145, 408);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(129, 30);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // webhookUrlTextBox
            // 
            this.webhookUrlTextBox.Animated = true;
            this.webhookUrlTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.webhookUrlTextBox.DefaultText = "";
            this.webhookUrlTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhookUrlTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhookUrlTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookUrlTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookUrlTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.webhookUrlTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookUrlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhookUrlTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.webhookUrlTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookUrlTextBox.Location = new System.Drawing.Point(109, 64);
            this.webhookUrlTextBox.Name = "webhookUrlTextBox";
            this.webhookUrlTextBox.PasswordChar = '\0';
            this.webhookUrlTextBox.PlaceholderText = "Webhook";
            this.webhookUrlTextBox.SelectedText = "";
            this.webhookUrlTextBox.Size = new System.Drawing.Size(200, 36);
            this.webhookUrlTextBox.TabIndex = 8;
            // 
            // delaySlider
            // 
            this.delaySlider.Location = new System.Drawing.Point(43, 71);
            this.delaySlider.Maximum = 10000;
            this.delaySlider.Minimum = 1500;
            this.delaySlider.Name = "delaySlider";
            this.delaySlider.Size = new System.Drawing.Size(300, 23);
            this.delaySlider.TabIndex = 9;
            this.delaySlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.delaySlider.Value = 1500;
            // 
            // delayLabel
            // 
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.delayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.delayLabel.Location = new System.Drawing.Point(163, 42);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(61, 23);
            this.delayLabel.TabIndex = 10;
            this.delayLabel.Text = "1500 ms";
            // 
            // enableSendingCheckBox
            // 
            this.enableSendingCheckBox.AutoSize = true;
            this.enableSendingCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enableSendingCheckBox.CheckedState.BorderRadius = 0;
            this.enableSendingCheckBox.CheckedState.BorderThickness = 0;
            this.enableSendingCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enableSendingCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSendingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.enableSendingCheckBox.Location = new System.Drawing.Point(163, 11);
            this.enableSendingCheckBox.Name = "enableSendingCheckBox";
            this.enableSendingCheckBox.Size = new System.Drawing.Size(70, 25);
            this.enableSendingCheckBox.TabIndex = 11;
            this.enableSendingCheckBox.Text = "Spam";
            this.enableSendingCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enableSendingCheckBox.UncheckedState.BorderRadius = 0;
            this.enableSendingCheckBox.UncheckedState.BorderThickness = 0;
            this.enableSendingCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enableSendingCheckBox.CheckedChanged += new System.EventHandler(this.enableSendingCheckBox_CheckedChanged);
            // 
            // logTextBox
            // 
            this.logTextBox.Animated = true;
            this.logTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logTextBox.DefaultText = "";
            this.logTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.logTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.logTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logTextBox.Location = new System.Drawing.Point(109, 148);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.PasswordChar = '\0';
            this.logTextBox.PlaceholderText = "Log";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.SelectedText = "";
            this.logTextBox.Size = new System.Drawing.Size(200, 36);
            this.logTextBox.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(69, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(244, 23);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Minimum delay bypasses discord";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.guna2Panel1.BorderRadius = 81;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.delayLabel);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.delaySlider);
            this.guna2Panel1.Controls.Add(this.enableSendingCheckBox);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 227);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(379, 164);
            this.guna2Panel1.TabIndex = 13;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Animated = true;
            this.nicknameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nicknameTextBox.DefaultText = "";
            this.nicknameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nicknameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nicknameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nicknameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicknameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nicknameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.nicknameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nicknameTextBox.Location = new System.Drawing.Point(109, 106);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.PasswordChar = '\0';
            this.nicknameTextBox.PlaceholderText = "Username";
            this.nicknameTextBox.SelectedText = "";
            this.nicknameTextBox.Size = new System.Drawing.Size(200, 36);
            this.nicknameTextBox.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.webhookUrlTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Webhook Messager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox messageTextBox;
        private Guna.UI2.WinForms.Guna2Button sendButton;
        private Guna.UI2.WinForms.Guna2TextBox webhookUrlTextBox;
        private Guna.UI2.WinForms.Guna2TrackBar delaySlider;
        private Guna.UI2.WinForms.Guna2HtmlLabel delayLabel;
        private Guna.UI2.WinForms.Guna2CheckBox enableSendingCheckBox;
        private Guna.UI2.WinForms.Guna2TextBox logTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox nicknameTextBox;
    }
}

