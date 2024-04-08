using GestionHotel.Apis.Domain.Bookings;

namespace GestionHotel.Apis.Services.Booking
{
	public class BookingService : IBookingService
	{
		public Task<Domain.Bookings.Booking> GetBookingById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Domain.Bookings.Booking>> GetBookingsByClientId(int clientId)
		{
			throw new NotImplementedException();
		}

		public Task<List<Domain.Bookings.Booking>> GetBookingsByRoomId(int roomId)
		{
			throw new NotImplementedException();
		}
	}
}
