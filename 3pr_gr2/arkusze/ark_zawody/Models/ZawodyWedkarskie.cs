using System;

namespace ark_zawody.Models;

public class ZawodyWedkarskie
{
    public int Id { get; set; }
    public int Karty_wedkarskie { get; set; }
    public int Lowisko_id { get; set; }
    public DateTime Data_zawodow { get; set; }
    public string Sedzia { get; set; }
}
