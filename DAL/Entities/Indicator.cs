using DAL.Enums;

namespace DAL.Entities;

public class Indicator
{
    public int Id { get; set; }
    public IndicatorType Type { get; set; }
    public double Value { get; set; }
    public string Location { get; set; } = null!;
    public DateTime MeasurementTime { get; set; }
    public int ReportId { get; set; }
    public Report Report { get; set; } = null!;
}