using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Deck
{
    public class CardDeck
    {
        private static readonly string[] valueVariants = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "B", "D", "K", "T"};
        private static readonly string[] suitsVariants = { "Heart", "Spades", "Clubs", "Diamonds" };

        private Card[] cards;  // Массив карт - это и есть колода

        public string DeckName { get; private set; }


        /// <summary>
        /// Создаёт новую колоду
        /// </summary>
        /// <param name="name">Название колоды</param>
        public CardDeck(string name)
        {
            DeckName = name;
            cards = new Card[52];

            int index = 0;
            foreach (string variant in valueVariants)
            {
                foreach (string suit in suitsVariants)
                {
                    cards[index++] = new Card(variant, suit);
                }
            }
        }
    }
}
