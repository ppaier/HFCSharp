using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishWinStore
{
    class Player
    {
        public string Name { get; private set; }

        private Random random;
        private Deck cards;
        private Game game;

        public Player(String name, Random random, Game game)
        {
            Name = name;
            this.random = random;
            this.game = game;
            cards = new Deck(new Card[] { });
            game.AddProgress(name + " has just joined the game");
        }

        public int CardCount
        {
            get
            {
                return cards.Count;
            }
        }

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }
        public void TakeCards(Deck deck)
        {
            cards.Add(deck);
        }

        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }

        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            cards.SortByValue();
        }


        public Values GetRandomValue()
        {
            Card randomCard = Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck foundCards = cards.PullOutValues(value);
            game.AddProgress(Name + " has " + foundCards.Count + " " + Card.Plural(value));
            return foundCards;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                AskForACard(players, myIndex, stock, GetRandomValue());
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            game.AddProgress(Name + " asks if anyone has a " + value.ToString());
            int numberOfFoundCards = 0;
            for(int i=0; i<players.Count; ++i)
            {
                if(i != myIndex)
                {
                    Deck foundCards = players[i].DoYouHaveAny(value);
                    numberOfFoundCards += foundCards.Count;
                    TakeCards(foundCards);
                }
            }

            if (numberOfFoundCards == 0 && stock.Count > 0)
            {
                TakeCard(stock.Deal());
                game.AddProgress(Name + " had to draw from the stock.");
            }
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for(int i=(int)Values.Ace; i<=(int)Values.King; ++i )
            {
                Values value = (Values)i;
                int howMany = 0;
                for(int card = 0; card < cards.Count; ++card)
                {
                    if (cards.Peek(card).Value == value)
                        ++howMany;
                }
                if(howMany==4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

    }
}
