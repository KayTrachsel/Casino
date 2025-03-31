using Casino;
using Game;
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
using System.Xml.Linq;

namespace Casino
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        CasGames casGames;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(CasGames chipHolder)
        {
            InitializeComponent();
            casGames = chipHolder;
            txtChips.Text = casGames.chips.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int roll = (casGames.RNJesus(0, 37));
            casGames.AwardChips(-100);
            if (casGames.bet == "") {
              MessageBox.Show("Please select a bet!");
            }
            switch (casGames.bet)
            {
                case "Red":
                    foreach (var item in casGames.red)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "1st2to1":
                    foreach (var item in casGames.first2to1)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "2nd2to1":
                    foreach (var item in casGames.second2to1)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "3rd2to1":
                    foreach (var item in casGames.third2to1)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "1-18":
                    foreach (var item in casGames.oneto18)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "19-36":
                    foreach (var item in casGames.nineteento36)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "1st12":
                    foreach (var item in casGames.first12)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "2nd12":
                    foreach (var item in casGames.second12)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "3rd12":
                    foreach (var item in casGames.third12)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "Black":
                    foreach (var item in casGames.black)
                    {
                        if (roll == item)
                        {
                            casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                            casGames.AwardChips(250);
                            break;
                        }
                        else
                        {
                            casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                        }
                    }
                    MessageBox.Show("You lose!");
                    break;
                case "Even":
                    if (roll % 2 == 0)
                    {
                        casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                        casGames.AwardChips(250);
                        break;
                    }
                    else
                    {
                        casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                    }
                    break;
                case "Odd":
                    if (roll % 2 != 0)
                    {
                       casGames.PrintRouletteMessage(true, false, txtRoulette, roll);
                       casGames.AwardChips(250);
                       break;
                    }
                    else
                    {
                       casGames.PrintRouletteMessage(false, false, txtRoulette, roll);
                    }
                    break;
                 default:
                    if (casGames.bet == roll.ToString())
                    {
                        casGames.PrintRouletteMessage(true, true, txtRoulette, roll);
                        casGames.AwardChips(400);
                    }
                    else
                    {
                        casGames.PrintRouletteMessage(false, true, txtRoulette, roll);
                    }
                    break;
            }
            txtChips.Text = casGames.chips.ToString();
        }
        private void Place_Bet(object sender, RoutedEventArgs e)
        {
            casGames.bet =  Convert.ToString(e.Source.GetType().GetProperty("Content").GetValue(e.Source, null));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).TransferChips(casGames.chips);
            this.Close();
            Owner.Show();
        }

        private void btnRussian_Click(object sender, RoutedEventArgs e)
        {

            if  (MessageBox.Show("Are you sure about that?", " ", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
            {
                if (MessageBox.Show("Are you SURE about that?", " ", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
                {
                    Russia russia = new Russia();
                    russia.Show();
                    russia.Owner = this.Owner;
                    russia.WindowState = WindowState.Maximized;
                }
            }
        }
    }
}