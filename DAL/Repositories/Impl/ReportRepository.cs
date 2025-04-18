using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl;

public class ReportRepository : BaseRepository<Report>, IReportRepository
{
    public ReportRepository(DbContext context) : base(context)
    {
    }
}