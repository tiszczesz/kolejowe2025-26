using System;

namespace pojazdy_sol.Models;

public class Alert
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public string Registration { get; set; }
    public string? Street { get; set; }
    public int Weight { get; set; }
    public DateOnly Day { get; set; }
    public TimeOnly Time { get; set; }
}
    
