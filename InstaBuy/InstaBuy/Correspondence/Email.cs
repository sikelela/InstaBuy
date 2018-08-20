namespace InstaBuy.Correspondence
{
  public class EmailService
  {
    /*
    public async Task SendAsync(IdentityMessage message)
    {
      await configSendGridasync(message);
    }

    // Use NuGet to install SendGrid (Basic C# client lib) 
    private async Task configSendGridasync(IdentityMessage message)
    {
      var myMessage = new SendGridMessage();
      myMessage.AddTo(message.Destination);
      myMessage.From = new EmailAddress("Joe@contoso.com", "Joe S.");
      myMessage.Subject = message.Subject;
      myMessage.PlainTextContent = message.Body;
      myMessage.HtmlContent = message.Body;

      var credentials = new NetworkCredential(ConfigurationManager.AppSettings["mailAccount"], ConfigurationManager.AppSettings["mailPassword"]);

      // Create a Web transport for sending email.
      var transportWeb = new System.Web.WebSockets(credentials);

      // Send the email.
      if (transportWeb != null)
      {
        await transportWeb.DeliverAsync(myMessage);
      }
      else
      {
        Trace.TraceError("Failed to create Web transport.");
        await Task.FromResult(0);
      }
    }
    */
  }
}
