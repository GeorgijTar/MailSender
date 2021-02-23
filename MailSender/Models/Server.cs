﻿namespace MailSender.Models
{
    public class Server
    {   
        public string Name { get; set; }
        public string Adres { get; set; }
        public int Port { get; set; } = 25;
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
     
    }
}
