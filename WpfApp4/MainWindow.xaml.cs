using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            bool czyPoprawnie = true;
            bool czyMalpa = true;
            bool czyRowne = true;
            if (!email.Text.ToString().Contains('@'))
            {
                czyPoprawnie = false;
                czyMalpa = false;
            }else
            if (!string.Equals(powtorzhaslo.Password.ToString(), haslo.Password.ToString()))
                    {
                czyPoprawnie = false;
                czyMalpa = false;
            }
            if (!czyMalpa) {
                komunikat.Text = "Niepoprawny email";
            }
            if (!czyRowne)
            {
                komunikat.Text = "Hasła nie są identyczne";
            }
            if (czyPoprawnie)
            {
                komunikat.Text = "Witaj " + email.Text;
            }


        }
    }
}