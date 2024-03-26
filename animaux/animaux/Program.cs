using System;

class Animaux
{
    static void Main(string[] args)
    {
        Animal lion = new Animal();

        lion.Move();
        lion.Sleep();
    }

    public class Animal
    {
        public string Name;

        public void Move()
        {
            Console.WriteLine("Moove");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public Animal()
        {
            Name = "Pas de Prénom";
        }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
