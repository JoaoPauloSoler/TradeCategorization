using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategorization.Models
{
    public interface ITrade 
    {
        double Value { get; } 
        string ClientSector { get; } 
        DateTime NextPaymentDate { get; } }
}
