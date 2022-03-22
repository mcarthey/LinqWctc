using System.Linq;
using LinqWctc.Models;

namespace LinqWctc.Dao
{
    public class DataContext : IDao
    {
        private readonly Repository repository;

        public DataContext()
        {
            repository = new Repository();
        }

        public void Add(Player player)
        {
            repository.Players.Add(player);
        }

        public Player Get()
        {
            return new Player
                {Name = "Toad", Description = "Enemy"};
        }

        public Player Search(string searchString)
        {
            var character = repository.Players.FirstOrDefault(x => x.Name == searchString);

            return character;
        }

        public Character SearchAll(string searchString)
        {
             
        }
    }
}
