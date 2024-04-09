using GestionHotel.Apis.Domain.Bookings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionHotel.Apis.Data.ModelConfigurations
{
	public class BookingConfiguration : IEntityTypeConfiguration<Booking>
	{
		public void Configure(EntityTypeBuilder<Booking> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.RoomId).IsRequired();
			builder.Property(b => b.CustomerId).IsRequired();
			builder.Property(b => b.StartDate).IsRequired();
			builder.Property(b => b.EndDate).IsRequired();
			builder.Property(b => b.PaymentMethod).HasMaxLength(50);
			builder.Property(b => b.PaymentStatus).IsRequired().HasMaxLength(50);
		}
	}
}
