using System.Security.Cryptography.X509Certificates;
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

namespace Casino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CasGames chipHolder = new CasGames();
        public MainWindow()
        {
            InitializeComponent();
            chipHolder.chips = 5000;
            txtChips.Text = chipHolder.chips.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Roulette = new Window1(chipHolder);
            Roulette.Show();
            Roulette.Owner = this;
            Roulette.WindowState = WindowState.Maximized;
            this.Hide();
        }

        private void btnBlackjack_Click(object sender, RoutedEventArgs e)
        {
            Window Blackjack = new Blackjack();    
            Blackjack.Show();
            Blackjack.Owner = this;
            Blackjack.WindowState = WindowState.Maximized;
            this.Hide();
        }

        private void btnCraps_Click(object sender, RoutedEventArgs e)
        {
            Window Craps = new Craps(chipHolder);
            Craps.Show();
            Craps.Owner = this;
            Craps.WindowState = WindowState.Maximized;
            this.Hide();
        }

        private void btnSlots_Click(object sender, RoutedEventArgs e)
        {
            Window Slots = new Slots(chipHolder);
            Slots.Show();
            Slots.Owner = this;
            Slots.WindowState = WindowState.Maximized;
            this.Hide();
        }
        public void TransferChips(int amount){
        chipHolder.chips = amount;
            txtChips.Text = chipHolder.chips.ToString();

        }
    }
}