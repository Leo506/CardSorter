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
        public void Shuffle(ref Card[] cards)
        {
            var random = new Random();

            for (int i = 0; i < cards.Length; i++)
            {
                var randomIndex = random.Next(cards.Length);
                var tmp = cards[randomIndex];
                cards[randomIndex] = cards[i];
                cards[i] = tmp;
            }
        }
    }
}
