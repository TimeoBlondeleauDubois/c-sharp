using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            this.id = Animal.animalCount++;
            this.Name = "Wolf";
            this.Rarity = 55;
        }

        public Wolf(string Name)
        {
            this.id = Animal.animalCount++;
            this.Name = Name;
            this.Rarity = 55;
        }

        public override void cry()
        {
            Console.WriteLine("Arou Arou !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.Name + " eat " + animal.Name);
        }
    }
}