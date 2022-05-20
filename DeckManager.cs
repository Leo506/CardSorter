using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Deck;

namespace TestTask
{
    public class DeckManager
    {
        private List<CardDeck> decks;

        public DeckManager()
        {
            decks = new List<CardDeck>();
        }


        /// <summary>
        /// Добавляет новую именованную колоду
        /// </summary>
        /// <param name="name">Имя колоды</param>
        /// <exception cref="InvalidOperationException"></exception>
        public void CreateNewDeck(string name)
        {
            if (GetAllNames().Contains(name))
                throw new InvalidOperationException("There is the same name");

            decks.Add(new CardDeck(name));
        }


        /// <summary>
        /// Удаляет колоду с заданным именем
        /// </summary>
        /// <param name="name">Имя колоды</param>
        /// <exception cref="InvalidOperationException"></exception>
        public void RemoveDeck(string name)
        {
            if (!GetAllNames().Contains(name))
                throw new InvalidOperationException("No decs with this name");

            decks.Remove(decks.Where(d => d.DeckName == name).ToArray()[0]);
        }


        /// <summary>
        /// Получение списка название колод
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllNames()
        {
            return decks.Select(d => d.DeckName).ToList();
        }
    }
}
