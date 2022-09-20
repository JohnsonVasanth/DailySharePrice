using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Models
{
    public class DailyStockDetails
    {
 

        [Key]
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int StockValue { get; set; }

        
    }
}
