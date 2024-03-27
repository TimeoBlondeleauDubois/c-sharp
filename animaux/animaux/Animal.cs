namespace cesiAnimal.animal
{
    public abstract class Animal
    {
        public static int animalCount;

        public int id;
        public String Name { get; protected set; }
        public int Rarity { get; protected set; }

        public void move()
        {
            if (Name == null)
            {
                Console.WriteLine("invisible animal move");

                return;
            }

            Console.WriteLine(Name + " move");
        }

        public void sleep()
        {
            if (Name == null)
            {
                Console.WriteLine("invisible animal sleep");

                return;
            }

            Console.WriteLine(Name + " sleep");
        }

        public abstract void cry();
    }
}