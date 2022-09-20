using DailySharePrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Repository
{
    public class SharePriceRepository:ISharePriceRepository
    {
        private readonly SharePriceContext db;
        public SharePriceRepository(SharePriceContext _db)
        {
            db = _db;
        }
        public DailyStockDetails GetShareByNameRepository(string shareName)
        {
            DailyStockDetails shareData = null;
            
            shareData= db.DailyStockDetails.Where(x => x.StockName == shareName).FirstOrDefault();
            return shareData;
        }
        public List <DailyStockDetails> GetAllstocks()
        {
            return db.DailyStockDetails.ToList();
        }
        
    }
}
