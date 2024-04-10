namespace GestionHotel.Apis.Domain.Bookings
{
	public interface IBookingService
	{
		Task<IEnumerable<Booking>> GetBookings();

		Task<Booking> GetBookingById(int id);

		Task<List<Booking>> GetBookingsByCustomerId(int customerId);

		Task<List<Booking>> GetBookingsByRoomId(int roomId);
	}
}
