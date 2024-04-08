namespace GestionHotel.Apis.Domain.Bookings
{
	public interface IBookingService
	{
		Task<Booking> GetBookingById(int id);

		Task<List<Booking>> GetBookingsByClientId(int clientId);

		Task<List<Booking>> GetBookingsByRoomId(int roomId);
	}
}
