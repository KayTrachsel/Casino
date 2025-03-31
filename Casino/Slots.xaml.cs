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
    /// Interaction logic for Slots.xaml
    /// </summary>
    public partial class Slots : Window
    {
        CasGames casGames;
        public Slots()
        {
            InitializeComponent();
        }
        public Slots(CasGames chipHolder)
        {
            InitializeComponent();
            casGames = chipHolder;
            txtChips.Text = casGames.chips.ToString();
        }

        private void btnSlots_Click(object sender, RoutedEventArgs e)
        {
            casGames.AwardChips(-100);
            int slot1 = casGames.RNJesus(1, 9);
            int slot2 = casGames.RNJesus(1, 9);
            int slot3 = casGames.RNJesus(1, 9);
            txtLeftSlot.Text = slot1.ToString();
            txtCenterSlot.Text = slot2.ToString();
            txtRightSlot.Text = slot3.ToString();
            if (slot1 == slot2 && slot1 == slot3)
            {
                switch (slot1)
                {
                    case 1:
                        casGames.AwardChips("First Jackpot", 1100 ); 
                        break;
                    case 2:
                        casGames.AwardChips("Second Jackpot", 2100); 
                        break;
                    case 3:
                        casGames.AwardChips("Third Jackpot", 3100); 
                        break;
                    case 4:
                        casGames.AwardChips("Forth Jackpot", 4100); 
                        break;
                    case 5:
                        casGames.AwardChips("Fifth Jackpot", 5100); 
                        break;
                    case 6:
                        casGames.AwardChips("Sixth Jackpot"    , 6100); 
                        break;
                    case 7:
                        casGames.AwardChips("Lucky You!!!"    , 7877);
                        break;
                    case 8:
                        casGames.AwardChips("Mega Jackpot"    , 10100);
                        break;
                }
            }
            else if (slot1 == slot2)
            {
                casGames.AwardChips("Payout of " + (slot3 * 100).ToString() + " times 1.0" + slot2.ToString(), slot1 * (1 + slot2 / 100));
            }
            else if (slot1 == slot3 )
            {
                casGames.AwardChips("Payout of " + (slot2 * 100).ToString() + " times 1.0" + slot1.ToString(), slot1 * (1 + slot2 / 100));
            }
            else if (slot2 == slot3)
            {
                casGames.AwardChips("Payout of " + (slot1 * 100).ToString() + " times 1.0" + slot2.ToString(), slot1 * (1 + slot2 / 100));
            }
            txtChips.Text = casGames.chips.ToString();

        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).TransferChips(casGames.chips);
            this.Close();
            Owner.Show();
        }

    private void txtCenterSlot_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
  }
}
