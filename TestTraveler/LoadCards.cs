using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using TestTravelerSorted;

namespace TestTraveler
{
    class LoadCards
    {
        List<string> lines = new List<string>();

        // Словарь для неотсортированных данных
        public Dictionary<string, Card> CardsInFrom { get; set; }

        public Dictionary<string, Card> CardsInTo { get; set; }

        // Словарь для данных после сор
        //private Dictionary<string, Card> _Cards { get; set; }

        public void Load()
        {
            CardsInFrom = new Dictionary<string, Card>();
            CardsInTo = new Dictionary<string, Card>();


            StreamReader reader = new StreamReader("Cards.txt",Encoding.Default);
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                Card card = new Card(s);
                
                lines.Add(s);

                CardsInFrom.Add(card.pointFrom, card);
                CardsInTo.Add(card.pointTo, card);
            }

            reader.Close();
        }
    }
}
