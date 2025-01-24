using System;
using System.Collections.Generic;

public class Patient
{
    public Patient()
    {
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Appointment> Appointments { get; set; }

}
