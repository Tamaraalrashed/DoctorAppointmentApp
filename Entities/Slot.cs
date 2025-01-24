using System;

public class Slot
{
    public Slot()
    {
    }

    public Guid Id { get; set; }
    public Guid DoctorId { get; set; }
    public bool IsReserved { get; set; }
    public DateTime Time { get; set; }
    public decimal Cost { get; set; }
    public Doctor Doctor { get; set; }
}
