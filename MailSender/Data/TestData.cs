using MailSender.Models;
using System.Collections.Generic;
using System.Linq;


namespace MailSender.Data
{
    static class TestData
    {
        public static List<Server> Servers { get; } = Enumerable.Range(1, 10).Select(i => new Server
        { 
        Name=$"Server-{i}",
        Adres=$"smtp.server{i}.ru",
        Login=$"Login-{i}",
        Password=$"Password-{i}",
        UseSSL=i%2==0                     
        }
        ).ToList();

        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10).Select(i => new Sender 
        {
            Name=$"Sender-{i}",
            Address=$"sender{i}@server.ru"
        }).ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10).Select(i => new Recipient
        {
            Name = $"Recipient-{i}",
            Address = $"recipient{i}@server.com"
        }).ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 50).Select(i => new Message 
        { 
        Title=$"Заголовок письма {i}",
        Text=$"Текст письма {i}"           
        }).ToList();
    }
}
