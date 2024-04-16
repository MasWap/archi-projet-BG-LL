using GestionHotel.Apis.Constants;
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
            builder.Property(b => b.StartDate).IsRequired();
            builder.Property(b => b.EndDate).IsRequired();
            builder.Property(b => b.PaymentMethod).HasMaxLength(50);
            builder.Property(b => b.PaymentStatus).IsRequired().HasMaxLength(50);
            builder.Property(b => b.CancellationStatus).HasMaxLength(255);
            builder.Property(b => b.CancellationRefund).HasMaxLength(255);
            builder.HasOne(b => b.Room).WithMany(r => r.Bookings).HasForeignKey(b => b.RoomId).IsRequired();
            builder.HasOne(b => b.Customer).WithMany(r => r.Bookings).HasForeignKey(b => b.CustomerId).IsRequired();

            builder.HasData(
                new Booking
                {
                    Id = 1,
                    RoomId = RoomConfiguration.Room1.Id,
                    CustomerId = CustomerConfiguration.Customer1.Id,
                    StartDate = new DateTime(2023, 03, 01),
                    EndDate = new DateTime(2023, 03, 05),
                    PaymentMethod = Convert.ToInt32(Class.PaymentMethod.CreditCard),
                    PaymentStatus = Convert.ToInt32(Class.PaymentStatus.Paid),
                    CancellationStatus = Convert.ToInt32(Class.CancellationStatus.Pending),
                    CancellationRefund = false
                },
                new Booking
                {
                    Id = 2,
                    RoomId = RoomConfiguration.Room2.Id,
                    CustomerId = CustomerConfiguration.Customer2.Id,
                    StartDate = new DateTime(2023, 03, 10),
                    EndDate = new DateTime(2023, 03, 12),
                    PaymentMethod = Convert.ToInt32(Class.PaymentMethod.PayPal),
                    PaymentStatus = Convert.ToInt32(Class.PaymentStatus.Pending),
                    CancellationStatus = Convert.ToInt32(Class.CancellationStatus.Pending),
                    CancellationRefund = false
                }
            );
        }
    }
}
