using BigBang.Models;
using BigBang.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigBang.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {

        private readonly IHotel hot;
        public HotelsController(IHotel hot)
        {
            this.hot = hot;
        }
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return hot.GetHotel();
        }

        [HttpGet("{HotelId}")]
        public Hotel GetById(int HotelId)
        {
            return hot.GetHotelById(HotelId);
        }

        [HttpPost]
        public Hotel PostHotel(Hotel hotel)
        {
            return hot.PostHotel(hotel);
        }
        [HttpPut("{HotelId}")]
        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            return hot.PutHotel(HotelId, hotel);
        }
        [HttpDelete("{HotelId}")]
        public Hotel DeleteHotel(int HotelId)
        {
            return hot.DeleteHotel(HotelId);
        }
    }
}
