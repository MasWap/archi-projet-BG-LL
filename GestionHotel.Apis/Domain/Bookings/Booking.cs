namespace GestionHotel.Apis.Domain.Bookings
{
	public class Booking
	{
		public int Id { get; set; }
		public int RoomId { get; set; }
		public int CustomerId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string PaymentMethod { get; set; }
		public string PaymentStatus { get; set; }
		public string CancellationStatus { get; set; }
		public bool CancellationRefund { get; set; }
	}
}
