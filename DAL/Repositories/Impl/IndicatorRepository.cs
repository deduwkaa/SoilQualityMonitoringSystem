using DAL.Data;
using DAL.Entities;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl
{
    public class IndicatorRepository : BaseRepository<Indicator>
    {
        public IndicatorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Indicator>> GetIndicatorsByReportIdAsync(int reportId)
        {
            return await _dbSet.Where(i => i.ReportId == reportId).ToListAsync();
        }
    }
}