
using TradeCategorization.Models;

namespace TradeCategorization.Categories
{
    public class ExpiredCategory : ICategory
    {
        public string Name => "EXPIRED";

        public bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return (referenceDate - trade.NextPaymentDate).Days > 30;
        }
    }
}
