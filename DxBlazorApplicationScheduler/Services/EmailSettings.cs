﻿namespace DxBlazorApplicationScheduler.Services
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; } = "";
        public int SmtpPort { get; set; } = 587;
        public string SmtpUser { get; set; } = "";
        public string SmtpPass { get; set; } = "";
        public string FromEmail { get; set; } = "";
        public string FromName { get; set; } = "My App";
    }
}
