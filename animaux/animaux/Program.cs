using System;

class Animaux
{
    static void Main(string[] args)
    {
       
    }

    public class Animal
    {
        public string name;

        public void Move()
        {
            Console.WriteLine("Moove");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public Animal(string name)
        {
            this.name = name;
        }


    }
}