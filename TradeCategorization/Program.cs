using TradeCategorization.Models;
using TradeCategorization.Services;

namespace TradeCategorization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read reference date
            Console.WriteLine("Enter the reference date (mm/dd/yyyy):");
            DateTime referenceDate;
            while (!DateTime.TryParse(Console.ReadLine(), out referenceDate))
            {
                Console.WriteLine("Invalid date format. Please enter the reference date (mm/dd/yyyy):");
            }

            // Read number of trades
            Console.WriteLine("Enter the number of trades:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid number. Please enter a positive integer for the number of trades:");
            }

            // Read trades
            List<ITrade> trades = new List<ITrade>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter trade {i + 1} details (value sector nextPaymentDate):");
                string[] tradeData = Console.ReadLine().Split(' ');

                if (tradeData.Length != 3 ||
                    !double.TryParse(tradeData[0], out double value) ||
                    (tradeData[1] != "Public" && tradeData[1] != "Private") ||
                    !DateTime.TryParse(tradeData[2], out DateTime nextPaymentDate))
                {
                    Console.WriteLine("Invalid input. Please enter the trade details in the format: value sector nextPaymentDate (e.g., 2000000 Private 12/29/2025)");
                    i--;
                    continue;
                }

                trades.Add(new Trade
                {
                    Value = value,
                    ClientSector = tradeData[1],
                    NextPaymentDate = nextPaymentDate
                });
            }

            // Categorize trades
            ICategoryService categoryService = new CategoryService();
            foreach (var trade in trades)
            {
                string category = categoryService.Categorize(trade, referenceDate);
                Console.WriteLine(category);
            }
        }
    }
}
