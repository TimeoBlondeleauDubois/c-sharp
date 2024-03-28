using cesiAnimal.animal;

namespace cesiAnimal.vehicle
{
    public abstract class Vehicle : Drivable
    {
        public String Name { get; protected set; }

        public Vehicle()
        {
            this.Name = "non-existent";
        }

        public Vehicle(String Name)
        {
            this.Name = Name;
        }

        public virtual void mount(Animal animal)
        {
            Console.WriteLine(animal.Name + " mount on " + this.Name);
        }

        public virtual void move()
        {
            Console.WriteLine(this.Name + " move");
        }

        public virtual void unmount(Animal animal)
        {
            Console.WriteLine(animal.Name + " unmount " + this.Name);
        }
    }
}