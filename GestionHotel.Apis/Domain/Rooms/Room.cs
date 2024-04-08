namespace GestionHotel.Apis.Domain.Rooms
{
	public class Room
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public int Capacity { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
	}
}
