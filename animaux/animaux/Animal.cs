public abstract class Animal
{
    private string _name;
    public string Name { get { return _name; } protected set { _name = value; } }

    public virtual void Move()
    {
        Console.WriteLine("Moove");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleep");
    }



}
      