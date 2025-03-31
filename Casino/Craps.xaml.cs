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

namespace Casino
{
    /// <summary>
    /// Interaction logic for Craps.xaml
    /// </summary>
    public partial class Craps : Window
    {
        CasGames casGames;
        public Craps()
        {
            InitializeComponent();
        }

        public Craps(CasGames chipHolder)
        {
            InitializeComponent();
            casGames = chipHolder;
            txtChips.Text= casGames.chips.ToString();
        }

        private void btnDiceroll_Click(object sender, RoutedEventArgs e)
        {
            casGames.AwardChips(-100);
            int roll1 = casGames.RNJesus(1, 7);
            int roll2 = casGames.RNJesus(1, 7);
            if (txtRoll1.Text == roll1.ToString())
            {
                casGames.AwardChips("You got 1 right",1000);
            }
            if (txtRoll2.Text == roll2.ToString())
            {
                casGames.AwardChips("You got 2 right",1000);
            }
            if (int.Parse(txtRoll1.Text) + int.Parse(txtRoll2.Text) == roll1 + roll2)
            {
                casGames.AwardChips("You got the result right",2000);
            }
            txtRoll1.Text = roll1.ToString();
            txtRoll2.Text = roll2.ToString();
            txtChips.Text = casGames.chips.ToString();
        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).TransferChips(casGames.chips);
            this.Close();
            Owner.Show();
        }

    private void txtRoll2_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
  }
}