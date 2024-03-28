namespace superhero.Models
{
    public class Hero
    {
        public string Name { get; set; }

        public string Power { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Power = "Unknown";
        }

        public Hero(string name, string power)
        {
            Name = name;
            Power = power;
        }
    }
}
