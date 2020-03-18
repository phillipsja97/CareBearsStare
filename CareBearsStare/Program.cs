using System;
using System.Collections.Generic;
using CareBearsStare.Bears;

namespace CareBearsStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            grumpyBear.Care("Nathan");
            var tenderHeart = new TenderHeart();
            tenderHeart.Stare();
            tenderHeart.Hug(grumpyBear);
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart};
            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }
            Console.ReadLine();
        }
    }
}
