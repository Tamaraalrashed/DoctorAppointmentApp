
using Entities;

using System;
using System.Collections.Generic;
namespace DoctorAppointmentManagement
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public List<Appointment> appointments; 
        public AppointmentRepository() : base()
        {
        }

        public IEnumerable<Appointment> FindAll()
        {
            appointments = Seeder.SeedAppointments(Guid.Parse("7a8c6840-94c8-45f1-a79b-5a6edc78dabd"));
            return appointments; 
        }

        public void Update(Appointment appointment)
        {
            if (appointment != null)
            {
                appointments[appointments.IndexOf(appointment)] = appointment;
            }
        }
    }
}
