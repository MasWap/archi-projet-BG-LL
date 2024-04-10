using GestionHotel.Apis.Data;
using GestionHotel.Apis.Domain.Employees;
using Microsoft.EntityFrameworkCore;

namespace GestionHotel.Apis.Persistence.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly HotelDbContext _context;

		public EmployeeRepository(HotelDbContext context)
		{
			_context = context;
		}

		public Task<Employee?> GetEmployeeById(int id)
		{
			return _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
		}

		public Task<List<Employee>> GetEmployeesByRole(string role)
		{
			return _context.Employees.Where(e => e.Role == role).ToListAsync();
		}
	}
}
