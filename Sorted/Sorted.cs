using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTravelerSorted

{
    public class Sorted
    {
        private Dictionary<string, Card> cardsInFrom;
        private Dictionary<string, Card> cardsInTo;
        private List<Card> cardsOut = new List<Card>();

        public List<Card> CardSorted
        {
            get { return cardsOut; }
        }
        public Sorted(Dictionary<string,Card> _cardsFrom, Dictionary<string, Card> _cardsTo)
        {
            cardsInFrom = _cardsFrom;
            cardsInTo = _cardsTo;
        }

        public void Sort()
        {
            Card cardStart=null;
            
            /// Определяем стартовую позицию
            foreach (var c in cardsInFrom.Values)
                if (!cardsInTo.Keys.Contains(c.pointFrom))
                    cardStart = c;



            if (cardStart != null)
                cardsOut.Add(cardStart);
            else
                //Стартовая позиция не найдена, список замкнут
                cardStart = cardsInFrom.Values.First();

            foreach (var c in cardsInFrom)
            {

                if (cardsInFrom.Keys.Contains(cardStart.pointTo))
                {
                    cardsOut.Add(cardsInFrom[cardStart.pointTo]);
                    cardStart = cardsInFrom[cardStart.pointTo];
                }
            }
        }

    }
}
