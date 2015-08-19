using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace GoFishWPF
{
    class Game
    {
        private List<Player> players;
        private ScrollViewer tbProgress;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private int round;

        public Game(string playerName, IEnumerable<string> opponentNames, ScrollViewer tbProgress)
        {
            this.tbProgress = tbProgress;
            tbProgress.Content = "";
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(playerName, random, tbProgress));
            round = 1;
            foreach (string p in opponentNames)
                players.Add(new Player(p, random, tbProgress));

            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            foreach(Player p in players)
            {
                for (int i=0; i < 5; ++i)
                {
                    Card card = stock.Deal();
                    p.TakeCard(card);
                }
                PullOutBooks(p);
            }
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribeBooks()
        {
            string description = "";
            foreach(Values value in books.Keys)
            {
                description += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;                 
            }
            return description;
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for(int i=0; i < players.Count;++i)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }

        public bool PlayOneRound(int selectedPlayerCardIdx)
        {
            tbProgress.Content += "Round: " + (round++) + Environment.NewLine;
            Values selectedPlayerValue = players[0].Peek(selectedPlayerCardIdx).Value;
            for(int i = 0; i < players.Count; ++i)
            {
                if (i == 0)
                    players[i].AskForACard(players, i, stock, selectedPlayerValue);
                else
                    players[i].AskForACard(players, i, stock);

                if(PullOutBooks(players[i]))
                {
                    tbProgress.Content += players[i].Name + " drew a new hand" + Environment.NewLine;
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        ++card;
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    tbProgress.Content = "The stock is out of cards. Game Over!" + Environment.NewLine;
                    return true;
                }
            }            
            return false;
        }

        private bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksOfPlayer = player.PullOutBooks();
            foreach(Values val in booksOfPlayer)
            {
                books[val] = player;
            }
            return player.CardCount == 0;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach(Values val in books.Keys)
            {
                if (winners.ContainsKey(books[val].Name))
                    ++winners[books[val].Name];
                else
                    winners.Add(books[val].Name, 1);
            }

            int numBooks = 0;
            List<string> winnerNames = new List<string>();
            foreach (string player in winners.Keys)
            {
                if(winners[player] == numBooks)
                {
                    winnerNames.Add(player);
                }
                else if(winners[player] > numBooks)
                {
                    winnerNames.Clear();
                    winnerNames.Add(player);
                    numBooks = winners[player];
                }
            }

            if (winnerNames.Count == 1)
            {
                return winnerNames[0] + " with " + numBooks + " books.";
            }
            else
            {
                string winnerString = "A tie between ";
                for (int i = 0; i < winnerNames.Count; ++i)
                {
                    winnerString += winnerNames[i];
                    if (i < winnerNames.Count - 1)
                        winnerString += " and ";
                    else
                        winnerString += " with " + numBooks + " books.";
                }
                return winnerString;
            }

        }
    }
}