using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            int count = deck.Cards.Count(x => x.Face == Faces.Ace);

            Console.WriteLine(count);
        }
    }
}
