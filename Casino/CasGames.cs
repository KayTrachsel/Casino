using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Casino
{
    public class CasGames
    {
        public string bet = "";
        Random random = new Random();
        public int[] black = new int[] { 1, 3, 5, 7,9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};
        public int[] red = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public int[] first2to1 = new int[] {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};
        public int[] second2to1 = new int[] {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35};
        public int[] third2to1 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};
        public int[] second12 = new int[] {13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
        public int[] first12 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public int[] third12 = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};
        public int[] oneto18 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        public int[] nineteento36 = new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};
        public int chips = 0;
        public int RNJesus(int min, int max)
        {
            return random.Next(min, max);
        }

        public void AwardChips(string message, int chipReward)
        {
            chips += chipReward;
            MessageBox.Show(message);
        }
        public void AwardChips(int chipReward)
        {
            chips += chipReward;
        }

        public void PrintRouletteMessage(bool won, bool hardBet, TextBox txtBox, int roll)
        {
        switch (hardBet)
        {
            case true:
                    if (won == true)
                    {
                         txtBox.Text = roll.ToString();
                         MessageBox.Show("You win big!");
                    }
                    else
                    {
                        txtBox.Text = roll.ToString();
                        MessageBox.Show("You lose big!");
                    }
                    break;
                case false:
                    if (won == true)
                    {
                        txtBox.Text = roll.ToString();
                        MessageBox.Show("You win!");
                    }
                    if (won == false)
                    {
                        txtBox.Text = roll.ToString();
                    }
                    break;
            }
        }
    }
}
