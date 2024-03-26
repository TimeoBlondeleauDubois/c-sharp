class Dragon : Animal
{
    public override void Move()
    {
        Console.WriteLine("Le dragon bouge.");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le dragon dort.");
    }

    public Dragon()
    {
        Name = "Pas de Prénom";
    }

    public Dragon(string name)
    {
        Name = name;
    }
}