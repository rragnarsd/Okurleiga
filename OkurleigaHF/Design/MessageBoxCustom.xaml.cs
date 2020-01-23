using System.Windows;

namespace OkurleigaHF.Design
{
    /// <summary>
    /// Interaction logic for msg.xaml
    /// </summary>
    public partial class MessageBoxCustom : Window
    {
        public string AlertMessage { get; set; }

        public MessageBoxCustom(string message)
        {
            InitializeComponent();

            AlertMessage = message;

            this.DataContext = this;

        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
