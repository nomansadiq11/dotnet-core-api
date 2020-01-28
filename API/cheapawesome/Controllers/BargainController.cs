using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace cheapawesome.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class BargainController : Controller
    {
        List<Hotel> hotels = new List<Hotel>();


        // load data on controstor 
        public BargainController()
        {

            

        }

        [HttpPost("FindBargain")]
        public JsonResult Post(BargainRequest bargainRequest)
        {
            loadhotels(1);
            loadhotels(2);

            //Hotel vhotel = new Hotel();

            try
            {

                hotels = hotels.Where(a => a.DestinationId == bargainRequest.DestinationID).ToList();
                //vhotel.hotels = hotels;
                //vhotel.rates = rates;


            }
            catch (Exception ex)
            {

            }

            return Json(hotels);
        }


        private void loadhotels(int hotelid)
        {
            hotels.Add(new Hotel()
            {
                DestinationId = hotelid,
                geoId = 1,
                HotelId = hotelid,
                name = "Hotel " + hotelid,
                PropertyId = 1,
                rating = 5,
                Rates = loadrates(hotelid)
            }
            );

            //hotels.Add(new Hotel()
            //{ DestinationId = 1, geoId = 1, HotelId = 2, name = "Hotel 2", PropertyId = 1, rating = 5, Rates = loadrates(hotelid) }
            //);

            //hotels.Add(new Hotel()
            //{ DestinationId = 2, geoId = 1, HotelId = 1, name = "Hotel 1", PropertyId = 1, rating = 5, Rates = loadrates(hotelid) }
            //);

            //hotels.Add(new Hotel()
            //{ DestinationId = 2, geoId = 1, HotelId = 2, name = "Hotel 2", PropertyId = 1, rating = 5, Rates = loadrates(hotelid) }
            //);

        }

        private List<Rate> loadrates(int hotelid)
        {
            List<Rate> rates = new List<Rate>();

            rates.Add(new Rate() { rateType = "Stay", boardType = "No Break fash", HotelId = hotelid, value = 100 });
            rates.Add(new Rate() { rateType = "Stay", boardType = "With Break fash", HotelId = hotelid, value = 200 });
            rates.Add(new Rate() { rateType = "Per Night", boardType = "No Break fash", HotelId = hotelid, value = 20 });
            rates.Add(new Rate() { rateType = "Per Night", boardType = "With Break fash", HotelId = hotelid, value = 40 });

            return rates;
        }

    }
}