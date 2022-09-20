using DailySharePrice.Models;
using DailySharePrice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailySharePriceController : ControllerBase
    {
        private readonly ISharePriceRepository sharePriceRepository;
        public DailySharePriceController(ISharePriceRepository _sharePriceRepository)
        {
            sharePriceRepository = _sharePriceRepository;
        }
        [HttpGet]
        [Route("stockname")]
        public IActionResult GetStockByName(string stockname)
        {
            
                if (stockname == null)
                {
                    return BadRequest();
                }
                var shareData = sharePriceRepository.GetShareByNameRepository(stockname);
                if (shareData == null)
                {
                    return BadRequest();
                }
                return Ok(shareData);

            
        }
        [HttpGet]
        public ActionResult GetAllStocks()
        {
            var l = sharePriceRepository.GetAllstocks();
            return Ok(l);
        

        }





    }
}
