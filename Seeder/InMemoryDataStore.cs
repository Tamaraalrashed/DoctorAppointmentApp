using System;
using System.Collections.Generic;

public sealed class InMemoryDataStore
{
    private static readonly Lazy<InMemoryDataStore> instance = new Lazy<InMemoryDataStore>(() => new InMemoryDataStore());

    // Access the singleton instance
    public static InMemoryDataStore Instance => instance.Value;
    public Doctor Doctor { get; private set; }
    public List<Patient> Patients { get; private set; }
    public List<Slot> Slots { get; private set; }
    public List<Appointment> Appointments { get; private set; }

    private InMemoryDataStore()
    {
        SeedDoctorName();
        SeedPatientsData();
        SeedDoctorSlots(Doctor.Id);
        SeedAppointments(Doctor.Id);
    }
    public void SeedDoctorName()
    {
        Doctor = new Doctor { Id = Guid.Parse("7a8c6840-94c8-45f1-a79b-5a6edc78dabd"), Name = "Dr.Omar" };
    }

    public void SeedPatientsData()
    {
        Patients = new List<Patient> { new Patient { Id = Guid.Parse("6e6e0c3e-3add-4aab-803c-da6ff4317ece8"), Name = "Mohammad" },
                                   new Patient { Id = Guid.Parse("7b15f5ca-492c-43e7-9feb-5dfe16b5dac0"), Name = "Ahmad" }
                                 };
    }

    public void SeedDoctorSlots(Guid doctorId)
    {
        Slots = new List<Slot> {
                    new Slot { Id = Guid.Parse("6d52183b-4949-4d79-a8cf-1ccac7b63151"), DoctorId = doctorId, Cost = 25, Time = new DateTime(2025, 1, 15, 10, 0, 0, 0), IsReserved = false },
                    new Slot { Id = Guid.Parse("58124892-4a4f-472d-adbc-355bf4c79687"), DoctorId = doctorId, Cost = 25, Time = new DateTime(2025, 1, 15, 11, 0, 0, 0), IsReserved = false },
                    new Slot { Id =  Guid.Parse("03d4ed4a-e817-4d09-80c5-822fcac5d225"), DoctorId = doctorId, Cost = 25, Time = new DateTime(2025, 1, 15, 11, 30, 0, 0), IsReserved = false }
           };
    }
    public void SeedAppointments(Guid doctorId)
    {
        Appointments = new List<Appointment> {
                    new Appointment { Id = Guid.Parse("d9629277-669f-4232-bad4-83f1f6925f1c"), DoctorId = doctorId,  PatientId = Guid.Parse("6e6e0c3e-3add-4aab-803c-da6ff4317ece8"),
                        ReservedAt = new DateTime(2025, 1, 14, 10, 0, 0, 0),  Status =  Entities.Enums.AppointmentStatusEnum.NotSet , SlotId =  Guid.Parse("6d52183b-4949-4d79-a8cf-1ccac7b63151")
                    } ,
            new Appointment { Id =Guid.Parse("7a95ea4c-0c08-4890-afe0-b4bce1803607"), DoctorId = doctorId,  PatientId = Guid.Parse("7b15f5ca-492c-43e7-9feb-5dfe16b5dac0"),
                        ReservedAt = new DateTime(2025, 1, 14, 10, 0, 0, 0),  Status =  Entities.Enums.AppointmentStatusEnum.NotSet , SlotId =  Guid.Parse("03d4ed4a-e817-4d09-80c5-822fcac5d225")
                    } ,

    };
    }
}
