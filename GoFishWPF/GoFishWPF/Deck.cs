using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GoFishWPF
{
    class Deck
    {
        private Random random = new Random();

        public List<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<Card>();
            for (int suit = (int)Suits.Spades; suit <= (int)Suits.Hearts; ++suit)
                for (int value = (int)Values.Ace; value <= (int)Values.King; ++value)
                    Cards.Add(new Card((Suits) suit, (Values) value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            Cards = new List<Card>(initialCards);
        }

        public Deck(string filename)
        {
            Cards = new List<Card>();
            using (StreamReader reader = new StreamReader(filename))
            {
                while(!reader.EndOfStream)
                {
                    bool invalidCard = false;
                    string nextCard = reader.ReadLine();
                    string[] cardParts = nextCard.Split(new char[] { ' ' });
                    Values value = Values.Ace;
                    switch (cardParts[0])
                    {
                        case "Ace":
                            value = Values.Ace;
                            break;
                        case "Two":
                            value = Values.Two;
                            break;
                        case "Three":
                            value = Values.Three;
                            break;
                        case "Four":
                            value = Values.Four;
                            break;
                        case "Five":
                            value = Values.Five;
                            break;
                        case "Six":
                            value = Values.Six;
                            break;
                        case "Seven":
                            value = Values.Seven;
                            break;
                        case "Eight":
                            value = Values.Eight;
                            break;
                        case "Nine":
                            value = Values.Nine;
                            break;
                        case "Ten":
                            value = Values.Ten;
                            break;
                        case "Jack":
                            value = Values.Jack;
                            break;
                        case "Queen":
                            value = Values.Queen;
                            break;
                        case "King":
                            value = Values.King;
                            break;
                        default:
                            invalidCard = true;
                            break;
                    }
                    Suits suit = Suits.Clubs;
                    switch (cardParts[2])
                    {
                        case ("Spades"):
                            suit = Suits.Spades;
                            break;
                        case ("Clubs"):
                            suit = Suits.Clubs;
                            break;
                        case ("Hearts"):
                            suit = Suits.Hearts;
                            break;
                        case ("Diamonds"):
                            suit = Suits.Diamonds;
                            break;
                        default:
                            invalidCard = true;
                            break;
                    }
                    if (!invalidCard)
                        Cards.Add(new Card(suit, value));
                }
            }
        }

        public int Count
        {
            get
            {
                return Cards.Count;
            }
        }

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public void Add(Deck deck)
        {
            foreach(Card card in deck.Cards)
                Cards.Add(card);
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = Cards[index];
            Cards.RemoveAt(index);
            return cardToDeal;
        }
        public Card Peek(int cardNumber)
        {
            return Cards[cardNumber];
        }

        public bool ContainsValue(Values value)
        {
            foreach(Card card in Cards)
            {
                if (card.Value == value)
                    return true;
            }
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for(int i = Cards.Count-1; i>= 0; --i)
            {
                if (Cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            }
            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach(Card card in Cards)
            {
                if (card.Value == value)
                    ++NumberOfCards;
            }
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }


        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            
            while(Cards.Count > 0)
            {
                int index = random.Next(Cards.Count);
                newCards.Add(Cards[index]);
                Cards.RemoveAt(index);
            }
            Cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[Cards.Count];
            for (int i = 0; i < Cards.Count; ++i)
                CardNames[i] = Cards[i].Name;
            return CardNames;
        }

        public void Sort()
        {
            Cards.Sort(new CardComparerBySuit());
        }

        public void SortByValue()
        {
            Cards.Sort(new CardComparerByValue());
        }

    }
}
