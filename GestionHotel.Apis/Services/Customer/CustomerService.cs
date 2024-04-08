using GestionHotel.Apis.Domain.Customers;

namespace GestionHotel.Apis.Services.Customer
{
	public class CustomerService : ICustomerService
	{
		public Task<Domain.Customers.Customer> CreateCustomer(Domain.Customers.Customer customer)
		{
			throw new NotImplementedException();
		}

		public Task<Domain.Customers.Customer> GetCustomerById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Domain.Customers.Customer> UpdateCustomer(Domain.Customers.Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
