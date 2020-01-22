using System.Windows;

namespace OkurleigaHF.Design
{
    /// <summary>
    /// Interaction logic for msg.xaml
    /// </summary>
    public partial class msg : Window
    {
        public msg()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window_Loaded);

        }

        private void Show_Click (object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
