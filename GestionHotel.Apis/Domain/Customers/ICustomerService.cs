namespace GestionHotel.Apis.Domain.Customers
{
	public interface ICustomerService
	{
		Task<Customer> GetCustomerById(int id);
		Task<Customer> CreateCustomer(Customer customer);
		Task<Customer> UpdateCustomer(Customer customer);
	}
}
