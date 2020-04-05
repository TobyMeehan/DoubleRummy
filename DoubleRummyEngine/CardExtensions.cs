using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public static class CardExtensions
    {
        public static bool TryAdd(this List<Card> cards, Card card, Validator validator, out List<Card> result)
        {
            result = new List<Card>(cards)
            {
                card
            };

            return validator(cards);
        }

        public static List<Card> FillDeck(this List<Card> cards)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    cards.Add(new Card((Suit)suit, value));
                }
            }

            for (int i = 0; i < 2; i++)
            {
                cards.Add(Card.Joker);
            }

            return cards;
        }
    }
}
