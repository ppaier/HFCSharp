using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GoFishWinStore
{
    class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private int round;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }


        public Game()
        {
            PlayerName = "Philipp";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
        }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();

            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach(string card in GetPlayerCardNames())
            {
                Hand.Add(card);
            }
            AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }
        private void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Hand.Clear();
        }

        public void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }
        public void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
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
                description = books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine + description;                 
            }
            return description;
        }

        public string DescribePlayerHands()
        {
            string description = "The stock has " + stock.Count + " cards left." + Environment.NewLine;
            for (int i=players.Count-1;i>=0 ;--i)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card.";
                else
                    description += " cards.";

                if(i>0)
                    description += Environment.NewLine;
            }
            return description;
        }

        public void PlayOneRound(int selectedPlayerCardIdx)
        {
            AddProgress("Round: " + (round++));
            Values selectedPlayerValue = players[0].Peek(selectedPlayerCardIdx).Value;
            for(int i = 0; i < players.Count; ++i)
            {
                if (i == 0)
                    players[i].AskForACard(players, i, stock, selectedPlayerValue);
                else
                    players[i].AskForACard(players, i, stock);

                if(PullOutBooks(players[i]))
                {
                    AddProgress(players[i].Name + " drew a new hand");
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        ++card;
                    }
                }
                OnPropertyChanged("Books");
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    AddProgress("The stock is out of cards. Game Over!");
                    AddProgress("The winner is... " + GetWinnerName());
                    ResetGame();
                    return;
                }
            }
            Hand.Clear();
            foreach (string card in GetPlayerCardNames())
                Hand.Add(card);
            if (GameInProgress)
                AddProgress(DescribePlayerHands());          
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