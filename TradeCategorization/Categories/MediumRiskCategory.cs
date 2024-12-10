using TradeCategorization.Models;

namespace TradeCategorization.Categories
{
    public class MediumRiskCategory : ICategory
    {
        public string Name => "MEDIUMRISK";

        public bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Public";
        }
    }
}
