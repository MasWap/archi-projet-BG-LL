using GestionHotel.Apis.Domain.Employees;

namespace GestionHotel.Apis.Persistence.Repositories
{
	public interface IEmployeeRepository
	{
		Task<Employee> GetEmployeeById(int id);

		Task<List<Employee>> GetEmployeesByRole(string role);
	}
}
