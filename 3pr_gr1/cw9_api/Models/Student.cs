using System;

namespace cw9_api.Models;

public class Student
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public double AVG_Grade { get; set; }
    public int Departament_id { get; set; }
}
