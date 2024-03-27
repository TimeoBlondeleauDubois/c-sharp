using System;
class Griffin : Animal
{

    public override void Move()
    {
        Console.WriteLine("le griffon bouge.");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le griffon dort.");
    }

    public Griffin()
    {
        Name = "Pas de Prénom";
    }

    public Griffin(string name)
    {
        Name = name;
    }

}