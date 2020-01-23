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
using System.Windows.Navigation;

namespace OkurleigaHF.Design
{
    /// <summary>
    /// Interaction logic for NewLoginWindow.xaml
    /// </summary>
    public partial class NewLoginWindow : Window
    {
        public NewLoginWindow()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (TxtEmail.Text == "okurleiga@okurleiga.is" & PwPassword.Password == "12345")
            {
                MainWindow win = new MainWindow();
                win.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBoxCustom win = new MessageBoxCustom("Reyndu aftur");
                win.ShowDialog();
            }

        }
    }
}
