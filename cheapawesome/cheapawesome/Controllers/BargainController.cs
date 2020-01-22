using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cheapawesome.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BargainController : Controller
    {
        List<Hotel> hotels = new List<Hotel>();
        List<Rate> rates = new List<Rate>();

        // load data on controstor 
        public BargainController()
        {
            loadhotels();
            loadrates();

        }

        [HttpPost("FindBargain")]
        public JsonResult Get(int destinationid, int nights, string code)
        {
            
            hotel vhotel = new hotel();

            try
            {

                
                vhotel.hotels = hotels;
                vhotel.rates = rates;


            }
            catch (Exception ex)
            {

            }

            return Json(vhotel);
        }


        private void loadhotels()
        {
            hotels.Add(new Hotel()
            { DestinationId = 1, geoId = 1, HotelId = 1, name = "Hotel 1", PropertyId = 1, rating = 5 }
            );

            hotels.Add(new Hotel()
            { DestinationId = 1, geoId = 1, HotelId = 2, name = "Hotel 2", PropertyId = 1, rating = 5 }
            );

            hotels.Add(new Hotel()
            { DestinationId = 2, geoId = 1, HotelId = 1, name = "Hotel 1", PropertyId = 1, rating = 5 }
            );

            hotels.Add(new Hotel()
            { DestinationId = 2, geoId = 1, HotelId = 2, name = "Hotel 2", PropertyId = 1, rating = 5 }
            );

        }

        private void loadrates()
        {
            rates.Add(new Rate() { rateType = "Stay", boardType = "No Break fash", HotelId = 1, value = 100 });
            rates.Add(new Rate() { rateType = "Stay", boardType = "With Break fash", HotelId = 2, value = 200 });
            rates.Add(new Rate() { rateType = "Per Night", boardType = "No Break fash", HotelId = 1, value = 20 });
            rates.Add(new Rate() { rateType = "Per Night", boardType = "With Break fash", HotelId = 2, value = 40 });
        }

    }
}