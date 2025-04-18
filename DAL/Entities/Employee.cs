namespace DAL.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Position { get; set; } = null!;
    public ICollection<Report> Reports { get; set; } = new List<Report>();
}