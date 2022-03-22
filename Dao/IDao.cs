using LinqWctc.Models;

namespace LinqWctc.Dao
{
    public interface IDao
    {
        void Add(Player player);
        Player Get();
        Player Search(string searchString);
    }
}
