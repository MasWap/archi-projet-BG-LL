using GestionHotel.Apis.Domain.Bookings;

namespace GestionHotel.Apis.Persistence.Repositories
{
	public interface IBookingRepository
	{
		Task<IEnumerable<Booking>> GetBookings();

		Task<Booking> GetBookingById(int id);

		Task<List<Booking>> GetBookingsByCustomerId(int customerId);

		Task<List<Booking>> GetBookingsByRoomId(int roomId);
	}
}
