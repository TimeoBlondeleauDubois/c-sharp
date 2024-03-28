using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    public class Bird : Animal
    {
        public Bird()
        {
            this.id = Animal.animalCount++;
            this.Name = "Bird";
            this.Rarity = 40;
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

