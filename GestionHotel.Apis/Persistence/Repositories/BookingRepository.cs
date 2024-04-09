using GestionHotel.Apis.Data;
using GestionHotel.Apis.Domain.Bookings;
using Microsoft.EntityFrameworkCore;

namespace GestionHotel.Apis.Persistence.Repositories
{
	public class BookingRepository : IBookingRepository
	{
		private readonly HotelDbContext _context;

		public BookingRepository(HotelDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Booking>> GetBookings()
		{
			return await _context.Bookings.ToListAsync();
		}

		public async Task<Booking?> GetBookingById(int id)
		{
			return await _context.Bookings.FirstOrDefaultAsync(b => b.Id == id);
		}

		public async Task<List<Booking>> GetBookingsByCustomerId(int customerId)
		{
			return await _context.Bookings.Where(b => b.CustomerId == customerId).ToListAsync();
		}

		public async Task<List<Booking>> GetBookingsByRoomId(int roomId)
		{
			return await _context.Bookings.Where(b => b.RoomId == roomId).ToListAsync();
		}
	}
}
