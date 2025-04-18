using DAL.Data;
using DAL.Entities;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Employee?> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Email == email);
        }
    }
}