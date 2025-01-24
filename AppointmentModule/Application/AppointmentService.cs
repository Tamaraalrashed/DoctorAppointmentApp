using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public void BookAppointment(Appointment appointment)
        {
            // Add business logic, e.g., check availability
            _repository.Add(appointment);
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _repository.GetAll();
        }
    }

}
