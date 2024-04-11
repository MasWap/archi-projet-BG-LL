using GestionHotel.Apis.Domain.Bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionHotel.Apis.Controllers.BookingManagement
{
	[ApiController]
	[Route("api/bookings")]
	public class BookingsController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingsController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}

		// GET /api/bookings
		[HttpGet]
		[Authorize]
		public async Task<ActionResult<List<Booking>>> GetAllBookings()
		{
			var bookings = await _bookingService.GetBookings();
			return Ok(bookings);
		}

		// GET /api/bookings/{id}
		[HttpGet("{id}")]
		[Authorize]
		public async Task<ActionResult<Booking>> GetBookingById(int id)
		{
			var booking = await _bookingService.GetBookingById(id);
			if (booking == null)
			{
				return NotFound();
			}
			return Ok(booking);
		}

		// GET /api/customers/{customerId}/bookings
		[HttpGet("customer/{customerId}")]
		[Authorize]
		public async Task<ActionResult<List<Booking>>> GetBookingsByCustomerId(int customerId)
		{
			var bookings = await _bookingService.GetBookingsByCustomerId(customerId);
			return Ok(bookings);
		}

		// GET /api/rooms/{roomId}/bookings
		[HttpGet("room/{roomId}")]
		[Authorize]
		public async Task<ActionResult<List<Booking>>> GetBookingsByRoomId(int roomId)
		{
			var bookings = await _bookingService.GetBookingsByRoomId(roomId);
			return Ok(bookings);
		}
	}
}
