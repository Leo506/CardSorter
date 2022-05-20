using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Deck
{
    /// <summary>
    /// Структура, представляющая карту
    /// </summary>
    public struct Card
    {
        public string Value { get; set; }  // Достоинство карты
        public string Suit { get; set; }   // Масть карты

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return Value + " " + Suit;
        }
    }
}
