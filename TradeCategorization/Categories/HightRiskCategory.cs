using TradeCategorization.Models;

namespace TradeCategorization.Categories
{
    public class HighRiskCategory : ICategory
    {
        public string Name => "HIGHRISK";
        public bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Private";
        }
    }
}
