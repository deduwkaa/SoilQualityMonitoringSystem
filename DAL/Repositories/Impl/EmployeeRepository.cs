using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Impl.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Impl;

public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(DbContext context) : base(context)
    {
    }
}