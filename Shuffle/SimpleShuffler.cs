using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Deck;

namespace TestTask.Shuffle
{
    public class SimpleShuffler : IShuffler
    {
        public int Shuffle(ref Card[] cards)
        {
            var random = new Random();
            int seed = random.Next(1001);

            random = new Random(seed);

            for (int i = 0; i < cards.Length; i++)
            {
                var randomIndex = random.Next(cards.Length);
                var tmp = cards[randomIndex];
                cards[randomIndex] = cards[i];
                cards[i] = tmp;
            }

            return seed;
        }
    }
}
