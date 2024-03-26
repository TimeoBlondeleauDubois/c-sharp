public abstract class Animal
{
    public string Name { get; private set; }

    public virtual void Move()
    {
        Console.WriteLine("Moove");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleep");
    }
}
      