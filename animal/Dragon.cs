using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using cesiAnimal.vehicle;

namespace cesiAnimal.animal
{
    internal class Dragon : Animal, Drivable
    {
        public Dragon()
        {
            this.id = Animal.animalCount++;
            this.Name = "Dragon";
            this.Rarity = 10;
        }

        public override void cry()
        {
            Console.WriteLine("Grrrr grr !");
        }

        public void eat(Animal animal)
        {
            Console.WriteLine(this.Name + " eat " + animal.Name);
        }

        public void eat(Vehicle vehicle)
        {
            Console.WriteLine(this.Name + " eat " + vehicle.Name + " vehicle");
        }

        public void mount(Animal animal)
        {
            Console.WriteLine(animal.Name + " mount on dragon");
        }

        public new void move()
        {
            Console.WriteLine("move with animal");
        }

        public void unmount(Animal animal)
        {
            Console.WriteLine(animal.Name + " unmount on dragon");

        }

        public override void fly()
        {
            Console.WriteLine(Name + " flies high in the sky!");
        }
    }
}
