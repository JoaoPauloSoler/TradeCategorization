
using TradeCategorization.Models;

namespace TradeCategorization.Categories
{
    public interface ICategory
    {
        string Name { get; }
        bool IsMatch(ITrade trade, DateTime referenceDate);
    }
}
