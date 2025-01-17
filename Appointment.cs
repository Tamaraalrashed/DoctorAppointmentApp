using System;

public class Appointment
{
    public Appointment()
    {
    }

    public Guid Id { get; set; }
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime ReservedAt { get; set; }
}
