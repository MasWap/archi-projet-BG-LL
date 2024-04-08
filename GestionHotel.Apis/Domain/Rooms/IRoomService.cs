﻿namespace GestionHotel.Apis.Domain.Rooms
{
	public interface IRoomService
	{
		Task<List<Room>> GetAvailableRooms(DateTime startDate, DateTime endDate);
		Task<Room> GetRoomById(int id);
		Task<Room> BookRoom(int roomId, int customerId, DateTime startDate, DateTime endDate, string paymentMethod);
		Task<bool> CancelBooking(int bookingId);
	}
}
