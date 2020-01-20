using MaterialDesignThemes.Wpf;
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

namespace OkurleigaHF.Design
{
    /// <summary>
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox()
        {
            InitializeComponent();

        }

        public class NotificationMessage
        {
            private string _message = "";
            private string _title = "";

            public string Message { get => _message; set => _message = value; }
            public string Title { get => _title; set => _title = value; }
        }

        public class ErrorNotificationMessage : NotificationMessage
        {
            public ErrorNotificationMessage()
            {
                Title = "Error";
            }
        }

        public class InfoNotificationMessage : NotificationMessage
        {
            public InfoNotificationMessage()
            {
                Title = "Info";
            }
        }

        public static bool IsOpen { get; private set; }

        private void ShowDialog_OnClick(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.IsOpen = true;
        }
    }
}
