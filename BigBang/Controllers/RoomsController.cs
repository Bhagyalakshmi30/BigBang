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
    public class RoomsController : ControllerBase
    {
        private readonly IRoom rom;
        public RoomsController(IRoom r)
        {
            this.rom = rom;
        }
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return rom.GetRoom();
        }

        [HttpGet("{RoomId}")]
        public Room GetById(int RoomId)
        {
            return rom.GetRoomById(RoomId);
        }

        [HttpPost]
        public Room PostRoom(Room room)
        {
            return rom.PostRoom(room);
        }
        [HttpPut("{RoomId}")]
        public Room PutRoom(int RoomId, Room room)
        {
            return rom.PutRoom(RoomId, room);
        }
        [HttpDelete("{RoomId}")]
        public Room DeleteRoom(int RoomId)
        {
            return rom.DeleteRoom(RoomId);
        }
    }
}
