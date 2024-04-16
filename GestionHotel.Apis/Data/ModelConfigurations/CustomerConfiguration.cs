using GestionHotel.Apis.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionHotel.Apis.Data.ModelConfigurations
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
        public static readonly Customer Customer1 = new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" };
        public static readonly Customer Customer2 = new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "987-654-3210" };
        public static readonly Customer Customer3 = new Customer { Id = 3, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "456-123-7890" };

        public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(c => c.LastName).IsRequired().HasMaxLength(50);
			builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
			builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(20);
			builder.HasMany(c => c.Bookings).WithOne(c => c.Customer);

			//builder.HasData(
   //             Customer1,
   //             Customer2,
   //             Customer3
   //         );

        }
    }
}
