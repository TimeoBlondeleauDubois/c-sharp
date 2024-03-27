class Dragon : Animal, IPilotage
{
    public override void Move()
    {
        Console.WriteLine("Le dragon bouge.");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le dragon dort.");
    }

    public void Move2()
    {
        Console.WriteLine("Le dragon bouge depuis pilotage.");
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