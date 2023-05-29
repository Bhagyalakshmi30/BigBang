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
    public class BookingsController : ControllerBase
    {

        private readonly IBooking book;
        public BookingsController(IBooking book)
        {
            this.book = book;
        }
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return book.GetBooking();
        }

        [HttpGet("{BookingId}")]
        public Booking GetById(int BookingId)
        {
            return book.GetBookingById(BookingId);
        }

        [HttpPost]
        public Booking PostBooking(Booking booking)
        {
            return book.PostBooking(booking);
        }
        [HttpPut("{BookingId}")]
        public Booking PutBooking(int BookingId, Booking booking)
        {
            return book.PutBooking(BookingId, booking);
        }
        [HttpDelete("{BookingId}")]
        public Booking DeleteBooking(int BookingId)
        {
            return book.DeleteBooking(BookingId);
        }
    }
}
