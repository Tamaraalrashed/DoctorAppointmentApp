using System;
using static Entities.Enums;

public class Appointment
{
    public Appointment()
    {
    }


    public Guid Id { get; set; }
    public Guid SlotId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime ReservedAt { get; set; }
    public AppointmentStatusEnum Status { get; set; }
    public Patient Patient { get; set; }
    public Slot Slot { get; set; }
    public Doctor Doctor { get; set; }



}


