using System;
using System.Net;
using System.Net.Mail;

namespace SenderNoAttach
{
    public class SenderMessage
    {
        string login;
        string password;
        string sender;
        string recipien;
        string server;
        string messageText;
        string messSubj;
        int serverPort;

        public SenderMessage(string login, string password, string sender, string recipien, string server, string messageText, string messSubj, string serverPort)
        {
            this.login = login;
            this.password = password;
            this.sender = sender;
            this.recipien = recipien;
            this.server = server;
            this.messageText = messageText;
            this.messSubj = messSubj;
            this.serverPort = int.Parse(serverPort);
        }

        public string MessageSend()
        {
            {

                var from = new MailAddress(sender, "");
                var to = new MailAddress(recipien, "");

                var message = new MailMessage(from, to);
                message.Subject = messSubj;
                message.Body = messageText;

                var client = new SmtpClient(server, serverPort);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential
                {
                    UserName = login,
                    Password = password
                };

                try
                {
                    client.Send(message);
                    return "Почта успешно отправлена!";
                }
                catch (SmtpException)

                {
                    return "Ошибка авторизации";
                }
                catch (TimeoutException)

                {
                    return "Ошибка адреса сервера";
                }

            }
        }
    }
}
