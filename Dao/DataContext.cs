using System.Collections.Generic;
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

        // Ignore for the time being as a valid implementation for Search across types
        // You will probably implement in your models that inherit from the abstract types
        public List<Character> SearchAll(string searchString)
        {
            List<Character> characterList = new List<Character>();

            var enemy = repository.Enemies.FirstOrDefault(x => x.Name == searchString);
            characterList.Add(enemy);

            var player = repository.Players.FirstOrDefault(x => x.Name == searchString);
            characterList.Add(player);

            return characterList;
        }
    }
}
