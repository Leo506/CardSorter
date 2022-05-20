using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Shuffle
{
    public interface IShuffler
    {
        /// <summary>
        /// Перемешивает колоду карт
        /// </summary>
        /// <param name="cards">Массив карт</param>
        /// <returns></returns>
        public int Shuffle(ref Deck.Card[] cards);
    }
}
