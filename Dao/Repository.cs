using System.Collections.Generic;
using LinqWctc.Models;

namespace LinqWctc.Dao
{
    public class Repository
    {
        public List<Player> Players { get; set; }
        public List<Enemy> Enemies { get; set; }

        public Repository()
        {
            Players = new List<Player>
            {
                new() {Name = "Mario", Description = "Red Plumber"},
                new() {Name = "Luigi", Description = "Green Plumber"},
            };
            Players.Add(new Player("Peach", "Princess"));

            Enemies = new List<Enemy>
            {
                new() {Name = "Donkey Kong", Description = "Gorilla"},
                new("Bowser", "Turtle")
            };
        }
    }
}
