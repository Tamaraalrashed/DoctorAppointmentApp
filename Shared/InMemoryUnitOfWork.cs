public class InMemoryUnitOfWork : IUnitOfWork
{
    public InMemoryUnitOfWork()
    {
        // DoctorAvailabilityRepository = new InMemoryDoctorAvailabilityRepository();
        //AppointmentBookingRepository = new InMemoryAppointmentBookingRepository();
        //DoctorAppointmentManagementRepository = new InMemoryDoctorAppointmentManagementRepository();
    }

    //public IDoctorAvailabilityRepository DoctorAvailabilityRepository { get; private set; }
    // public IAppointmentBookingRepository AppointmentBookingRepository { get; private set; }
    // public IDoctorAppointmentManagementRepository DoctorAppointmentManagementRepository { get; private set; }

    public void Commit()
    {
        // No-op for in-memory implementation
    }

    public void Rollback()
    {
        // Optionally reset state if rollback is needed
    }

    public void Dispose()
    {
        // Clean up resources if necessary
    }
}
