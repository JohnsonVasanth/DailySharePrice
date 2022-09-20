using DailySharePrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Repository
{
    public interface ISharePriceRepository
    {
        public DailyStockDetails GetShareByNameRepository(string shareName);
        List<DailyStockDetails> GetAllstocks();
    }
}
