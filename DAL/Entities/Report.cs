using DAL.Enums;

namespace DAL.Entities;

public class Report
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public ReportStatus Status { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    
    public ICollection<Indicator> Indicators { get; set; } = new List<Indicator>();
}