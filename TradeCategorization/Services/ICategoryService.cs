using System;
using System.Collections.Generic;
using TradeCategorization.Models;

namespace TradeCategorization.Services
{
    public interface ICategoryService
    {
        string Categorize(ITrade trade, DateTime referenceDate);
    }
}
