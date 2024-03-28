using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    internal class Sheep : Animal
    {
        public Sheep()
        {
            this.id = Animal.animalCount++;
            this.Name = "Sheep";
            this.Rarity = 75;
        }

        public override void cry()
        {
            Console.WriteLine("Bee Bee !");
        }

        public override void fly()
        {
            Console.WriteLine(Name + " don't flies in the sky!");
        }
    }
}
