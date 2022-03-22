namespace LinqWctc.Models
{
    public class Enemy : Character
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public Enemy()
        {
        }

        public Enemy(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
