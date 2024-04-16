﻿using GestionHotel.Apis.Domain.Bookings;

namespace GestionHotel.Apis.Domain.Customers
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
