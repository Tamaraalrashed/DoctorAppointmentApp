using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Entities.Enums;

namespace DoctorAppointmentManagement
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _repository;
        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Appointment> FindAll()
        {
            return _repository.FindAll();
        }
        public void ManageAppointments(Guid appointmentId, AppointmentStatusEnum appointmentStatusEnum)
        {
            List<Appointment> appointments = FindAll().ToList();
            Appointment appointment = appointments.Where(ap => ap.Id == appointmentId).FirstOrDefault();
            appointment.Status = appointmentStatusEnum;
            _repository.Update(appointment);

        }
    }
}
