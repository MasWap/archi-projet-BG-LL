﻿using GestionHotel.Apis.Data;
using GestionHotel.Apis.Domain.Rooms;
using Microsoft.EntityFrameworkCore;

namespace GestionHotel.Apis.Persistence.Repositories
{
	public class RoomRepository : IRoomRepository
	{
		private readonly HotelDbContext _context;

		public RoomRepository(HotelDbContext context) 
		{ 
			_context = context; 
		}

		public Task<List<Room>> GetRooms()
		{
			return _context.Rooms.ToListAsync();
		}

		public Task<Room?> GetRoomById(int id)
		{
			return _context.Rooms.FirstOrDefaultAsync(r => r.Id == id);
		}

		public void UpdateRoom(Room room)
		{
			_context.Rooms.Update(room);
		}

		public void AddRoom(Room room)
		{
			_context.Rooms.Add(room);
		}

		public void RemoveRoom(Room room)
		{
			_context.Rooms.Remove(room);
		}
	}
}
