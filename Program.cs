using LinqWctc.Dao;
using LinqWctc.Models;

namespace LinqWctc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new DataContext();
            var character = context.Get();

            // Ask user for searchString
            var searchedCharacter = context.Search("Yoshi");

            Character player = new Player();
            Character enemy = new Enemy();

            // example implementation
            //player.Search();
            //enemy.Search();
        }
    }
}
