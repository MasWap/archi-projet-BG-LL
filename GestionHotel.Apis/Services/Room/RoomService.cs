using GestionHotel.Apis.Domain.Rooms;

namespace GestionHotel.Apis.Services.Room
{
	public class RoomService : IRoomService
	{
		public Task<Domain.Rooms.Room> BookRoom(int roomId, int customerId, DateTime startDate, DateTime endDate, string paymentMethod)
		{
			throw new NotImplementedException();
		}

		public Task<bool> CancelBooking(int bookingId)
		{
			throw new NotImplementedException();
		}

		public Task<List<Domain.Rooms.Room>> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			throw new NotImplementedException();
		}

		public Task<Domain.Rooms.Room> GetRoomById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
