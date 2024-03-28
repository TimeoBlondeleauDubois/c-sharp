using cesiAnimal.animal;

namespace cesiAnimal.vehicle
{
    public class Ship : Vehicle
    {
        public Ship()
        {
            this.Name = "ship";
        }

        public override void mount(Animal animal)
        {
            Console.WriteLine(animal.Name + " mount on " + this.Name);
        }

        public override void move()
        {
            Console.WriteLine(this.Name + " move");
        }

        public override void unmount(Animal animal)
        {
            Console.WriteLine(animal.Name + " unmount " + this.Name);
        }
    }
}