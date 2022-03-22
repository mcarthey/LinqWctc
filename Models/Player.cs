namespace LinqWctc.Models
{
    public class Player : Character
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public Player()
        {
        }

        public Player(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
