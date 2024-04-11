using GestionHotel.Apis.Domain.Rooms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionHotel.Apis.Controllers.RoomManagement
{
	[ApiController]
	[Route("api/rooms")]
	[Authorize]
	public class RoomsController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomsController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		// GET /api/rooms/available
		[HttpGet("available")]
		public async Task<ActionResult<List<Room>>> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			var rooms = await _roomService.GetAvailableRooms(startDate, endDate);
			return Ok(rooms);
		}
	}

	// Classe de transfert de données pour la réservation d'une chambre
	public class RoomBooking
	{
		public int CustomerId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string PaymentMethod { get; set; }
	}
}
