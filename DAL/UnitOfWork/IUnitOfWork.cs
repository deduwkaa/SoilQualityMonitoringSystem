using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork;

public interface IUnitOfWork
{
    IEmployeeRepository Employees { get; }
    IIndicatorRepository Indicators { get; }
    IReportRepository Reports { get; }
    Task<int> SaveAsync();
}