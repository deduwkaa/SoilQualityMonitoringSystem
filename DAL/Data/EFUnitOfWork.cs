using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;

namespace DAL.Data;

public class EFUnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public IEmployeeRepository Employees { get; }
    public IIndicatorRepository Indicators { get; }
    public IReportRepository Reports { get; }

    public EFUnitOfWork(ApplicationDbContext context,
        IEmployeeRepository employeeRepository,
        IIndicatorRepository indicatorRepository,
        IReportRepository reportRepository)
    {
        _context = context;
        Employees = employeeRepository;
        Indicators = indicatorRepository;
        Reports = reportRepository;
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}