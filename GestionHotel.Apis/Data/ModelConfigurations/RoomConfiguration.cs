using GestionHotel.Apis.Constants;
using GestionHotel.Apis.Domain.Rooms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionHotel.Apis.Data.ModelConfigurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public static readonly Room Room1 = new Room { Id = 1, Capacity = 6, Price = 75, Status = Convert.ToInt32(Class.RoomStatus.Free) };
        public static readonly Room Room2 = new Room { Id = 2, Capacity = 4, Price = 50, Status = Convert.ToInt32(Class.RoomStatus.Free) };
        public static readonly Room Room3 = new Room { Id = 3, Capacity = 2, Price = 40, Status = Convert.ToInt32(Class.RoomStatus.Free) };
        public static readonly Room Room4 = new Room { Id = 4, Capacity = 2, Price = 40, Status = Convert.ToInt32(Class.RoomStatus.Free) };
        public static readonly Room Room5 = new Room { Id = 5, Capacity = 2, Price = 40, Status = Convert.ToInt32(Class.RoomStatus.Unavailable) };

        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Type).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Capacity).IsRequired();
            builder.Property(c => c.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(c => c.Status).IsRequired().HasMaxLength(50);

            builder.HasData(
                Room1,
                Room2,
                Room3,
                Room4,
                Room5
            );
        }
    }
}
