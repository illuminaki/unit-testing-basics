namespace UnitTestingBasics
{
    /// <summary>
    /// Represents a contract for sending emails.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Sends an email with the provided parameters.
        /// </summary>
        /// <param name="recipient">The email address of the recipient.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="body">The body content of the email.</param>
        void SendEmail(string recipient, string subject, string body);
    }

    /// <summary>
    /// A service that sends welcome emails using an IEmailSender dependency.
    /// </summary>
    public class EmailService
    {
        private readonly IEmailSender _emailSender;

        /// <summary>
        /// Initializes a new instance of the EmailService.
        /// </summary>
        /// <param name="emailSender">An implementation of IEmailSender.</param>
        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        /// <summary>
        /// Sends a welcome email to a specified user email address.
        /// Returns true if successful, otherwise false.
        /// </summary>
        /// <param name="userEmail">The user's email address.</param>
        /// <returns>True if the email was sent, false otherwise.</returns>
        public bool SendWelcomeEmail(string userEmail)
        {
            if (string.IsNullOrEmpty(userEmail))
            {
                // If email is invalid, don't send
                return false;
            }

            // Use the injected IEmailSender to send the email
            _emailSender.SendEmail(
                userEmail,
                "Welcome to Our Service",
                "Hello! This is your welcome email. Enjoy our service!"
            );

            return true;
        }
    }
}
