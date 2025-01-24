
using System;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    void Rollback();

    //IDoctorAvailabilityRepository DoctorAvailabilityRepository { get; }
    //IAppointmentBookingRepository AppointmentBookingRepository { get; }
    //IDoctorAppointmentManagementRepository DoctorAppointmentManagementRepository { get; }
}


