namespace DxBlazorApplicationScheduler.Services
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; } = "localhost";
        public int SmtpPort { get; set; } = 25;
        public string SmtpUser { get; set; } = "";
        public string SmtpPass { get; set; } = "";
        public string FromEmail { get; set; } = "test@local.dev";
        public string FromName { get; set; } = "SchedulerApp";
    }
}
