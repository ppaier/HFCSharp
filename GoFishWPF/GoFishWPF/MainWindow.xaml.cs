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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoFishWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter your name!", "Can't start the game yet");
                return;
            }
            game = new Game(tbName.Text, new List<string> { "Joe", "Bob" }, tbProgress);
            btStart.IsEnabled = false;
            tbName.IsEnabled = false;
            btCard.IsEnabled = true;
            UpdateForm();
        }


        private void UpdateForm()
        {
            lbHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                lbHand.Items.Add(cardName);
            tbBooks.Content = game.DescribeBooks();
            tbBooks.ScrollToEnd();
            tbProgress.Content += game.DescribePlayerHands();
            tbProgress.ScrollToEnd();
        }

        private void btCard_Click(object sender, RoutedEventArgs e)
        {
            tbProgress.Content = "";
            if (lbHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(lbHand.SelectedIndex))
            {
                tbProgress.Content += "The winner is..." + game.GetWinnerName();
                tbBooks.Content = game.DescribeBooks();
                btCard.IsEnabled = false;
                btStart.IsEnabled = true;
                tbName.IsEnabled = true;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}
