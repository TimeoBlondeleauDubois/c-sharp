using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    public class Aigle : Animal
    {
        public Aigle()
        {
            this.id = Animal.animalCount++;
            this.Name = "Aigle";
            this.Rarity = 60;
        }

        public override void cry()
        {
            Console.WriteLine("Chirp chirp!");
        }

        public override void fly()
        {
            Console.WriteLine(Name + " flies gracefully through the air.");
        }
    }
}

