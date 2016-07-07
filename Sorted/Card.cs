using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTravelerSorted
{
    public class Card
    {
        public Card(string value)
        {
            string[] points = value.Split(';');
            pointFrom = points[0];
            pointTo = points[1];
        }

        public string pointFrom { get; set; }
        public string pointTo { get; set; }
        
    }
    
}
