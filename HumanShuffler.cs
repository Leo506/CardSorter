using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Deck;

namespace TestTask.Shuffle
{
    public class HumanShuffler : IShuffler
    {
        public void Shuffle(ref Card[] cards)
        {
            var random = new Random();
            int countOfChange = random.Next(51);  // Сколько раз поменять местами

            // Если меняем четное кол-во раз - то колода не меняется
            if (countOfChange % 2 == 0)
                return;



            for (int i = 0; i < countOfChange; i++)
            {
                // Меняем две части колоды местами
                for (int j = 0; j < cards.Length / 2; j++)
                {
                    var tmp = cards[j];
                    cards[j] = cards[cards.Length - 1 - j];
                    cards[cards.Length - 1 - j] = tmp;
                }
            }
        }
    }
}
