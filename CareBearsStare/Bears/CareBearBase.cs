using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    abstract class CareBearBase
    {
        public string Name { get; protected set; }
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }

        public abstract void Stare(); // inheriting class has to define it.
        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}."); // this has already been defined it.
        }

        public virtual void Hug(CareBearBase careBearToHug) // virtual means that each instantiation can modify it, but it has already been defined.
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }

    }
}
