using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleRummyEngine
{
    public class RoundDefaults
    {
        public static List<Round> DoubleRummy
        {
            get
            {
                return new List<Round>
                {
                    new Round(new[]
                    {
                        RequireBlock(3),
                        RequireBlock(3)
                    }),
                    new Round(new[]
                    {
                        RequireRun(3),
                        RequireRun(3)
                    }),
                    new Round(new[]
                    {
                        RequireRun(3),
                        RequireBlock(3)
                    }),
                    new Round(new[]
                    {
                        RequireRun(4),
                        RequireBlock(3)
                    }),
                    new Round(new[]
                    {
                        RequireBlock(4),
                        RequireRun(3)
                    }),
                    new Round(new[]
                    {
                        RequireBlock(4),
                        RequireBlock(4)
                    }),
                    new Round(new[]
                    {
                        RequireRun(4),
                        RequireRun(4)
                    }),
                    new Round(new[]
                    {
                        RequireRun(4),
                        RequireBlock(4)
                    }),
                    new Round(new[]
                    {
                        RequireRun(3),
                        RequireRun(3),
                        RequireBlock(4)
                    })
                };
            }
        }

        public static Validator RequireRun(int length)
        {
            return (cards) =>
            {
                cards = cards.OrderBy(c => c.Value).ToList();

                bool valid = true;

                valid = cards.Count >= length && valid;
                valid = cards.TrueForAll(c => c.Suit == cards.First().Suit) && valid; // All suits match
                valid = cards.TrueForAll(c => c.Value == cards[cards.IndexOf(c)]?.Value - 1) && valid; // For every card, the next card's value is the previous + 1

                return valid;
            };
        }

        public static Validator RequireBlock(int length)
        {
            return (cards) =>
            {
                return cards.TrueForAll(c => c.Value == cards.First().Value) && cards.Count >= length;
            };
        }

        public const int StartingBalance = 30;
    }
}
