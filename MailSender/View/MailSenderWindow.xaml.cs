using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SenderNoAttach;

namespace MailSender.View
{
    /// <summary>
    /// Логика взаимодействия для MailSenderWindow.xaml
    /// </summary>
    public partial class MailSenderWindow : Window
    {
        public MailSenderWindow()
        {
            InitializeComponent();
        }

        private void TabItem_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            SenderMessage mess = new SenderMessage(LoginEd.Text, PassvordEd.Password, SenderEd.Text, RecipientEd.Text,
                              ServerEd.Text, MessageEd.Text, MessSubj.Text, ServerPort.Text);
            MessageBox.Show(mess.MessageSend(), "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
