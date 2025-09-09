using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace DxBlazorApplicationScheduler.Services
{
    public class EmailService : IEmailSender
    {
        private readonly EmailSettings _settings;

        public EmailService(EmailSettings settings)
        {
            _settings = settings;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlBody)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_settings.FromName, _settings.FromEmail));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = subject;

            var builder = new BodyBuilder { HtmlBody = htmlBody };
            message.Body = builder.ToMessageBody();

            try
            {
                using var smtp = new SmtpClient();
                Console.WriteLine("Connecting to SMTP server...");

                // Use startTLS in production, current setup for local testing
                await smtp.ConnectAsync(_settings.SmtpServer, _settings.SmtpPort, SecureSocketOptions.None);
                Console.WriteLine("Connected to SMTP");


                await smtp.AuthenticateAsync(_settings.SmtpUser, _settings.SmtpPass);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                // Log ex.Message or print to console to see errors
                Console.WriteLine("Email sending failed: " + ex.Message);
                throw;
            }
        }


        public string GenerateAppointmentHtml(string name, DateTime start, DateTime end, string location)
        {
            return $@"
    <!DOCTYPE html>
    <html>
    <head>
      <meta charset='UTF-8'>
      <style>
        body {{
          font-family: Arial, sans-serif;
          background-color: #f8f9fa;
          padding: 20px;
          color: #333;
        }}
        .container {{
          background-color: #ffffff;
          padding: 20px;
          border-radius: 8px;
          border: 1px solid #dddddd;
          max-width: 600px;
          margin: 0 auto;
        }}
        .header {{
          font-size: 20px;
          font-weight: bold;
          color: #007bff;
        }}
        .content {{
          margin-top: 10px;
          font-size: 16px;
        }}
        .footer {{
          margin-top: 30px;
          font-size: 14px;
          color: #777;
        }}
      </style>
    </head>
    <body>
      <div class='container'>
        <div class='header'>Appointment Created</div>
        <div class='content'>
          Hello,<br><br>
          Your appointment with <strong>{name}</strong> has been successfully created.<br><br>
          <strong>Date:</strong> {start:yyyy-MM-dd}<br>
          <strong>Time:</strong> {start:HH:mm} - {end:HH:mm}<br>
          <strong>Location:</strong> {location}<br><br>
          If you have any questions or need to reschedule, please contact us.
        </div>
        <div class='footer'>
          This is an automated message. Please do not reply.
        </div>
      </div>
    </body>
    </html>
    ";
        }
    }
}
