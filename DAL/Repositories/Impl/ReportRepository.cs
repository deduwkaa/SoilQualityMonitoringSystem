using DAL.Data;
using DAL.Entities;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl
{
    public class ReportRepository : BaseRepository<Report>
    {
        public ReportRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Report>> GetReportsByEmployeeIdAsync(int employeeId)
        {
            return await _dbSet.Where(r => r.EmployeeId == employeeId).ToListAsync();
        }
    }
}