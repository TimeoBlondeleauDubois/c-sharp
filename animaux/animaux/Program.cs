using System;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> dogs = new List<Animal>();

        dogs.Add(new Dog("Snow"));
        dogs.Add(new Dog("Rex"));
        dogs.Add(new Dog("Buddy"));
        dogs.Add(new Dog("Max"));
        dogs.Add(new Dog("Alexandre"));

        var testDogs = from dog in dogs where dog.Name != "Snow" select dog;

        foreach (Dog testDog in testDogs)
        {
            Console.WriteLine(testDog.Name);
        }
    }
}