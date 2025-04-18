using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl;

public class IndicatorRepository : BaseRepository<Indicator>, IIndicatorRepository
{
    public IndicatorRepository(DbContext context) : base(context)
    {
    }
}