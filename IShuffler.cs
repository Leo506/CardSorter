using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Shuffle
{
    public interface IShuffler
    {
        public void Shuffle(ref Deck.Card[] cards);
    }
}
