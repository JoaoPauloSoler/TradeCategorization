using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategorization.Models
{
    public class Trade : ITrade
    {
        public double Value { get; set; }
        public required string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
    }
}
