using Casino;
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

namespace Game
{
    /// <summary>
    /// Interaction logic for Russia.xaml
    /// </summary>
    public partial class Russia : Window
    {
        public Russia()
        {
            InitializeComponent();
        }
        CasGames games = new CasGames();
        
        private void Place_Bet(object sender, RoutedEventArgs e)
        {
            games.bet = Convert.ToString(e.Source.GetType().GetProperty("Content").GetValue(e.Source, null));
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            int roll = (games.RNJesus(1, 7));
            if (games.bet == roll.ToString())
            {
                Owner.Close();
            }
        }
    }
}
