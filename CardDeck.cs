using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Deck
{
    public class CardDeck : IEnumerable<Card>
    {
        private static readonly string[] valueVariants = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "B", "D", "K", "T"};
        private static readonly string[] suitsVariants = { "Heart", "Spades", "Clubs", "Diamonds" };

        public Card[] Cards;  // Массив карт - это и есть колода

        public string DeckName { get; private set; }


        /// <summary>
        /// Создаёт новую колоду
        /// </summary>
        /// <param name="name">Название колоды</param>
        public CardDeck(string name)
        {
            DeckName = name;
            Cards = new Card[52];

            int index = 0;
            foreach (string variant in valueVariants)
            {
                foreach (string suit in suitsVariants)
                {
                    Cards[index++] = new Card(variant, suit);
                }
            }
        }

        public IEnumerator<Card> GetEnumerator()
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                yield return Cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
