using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentModule
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();


        public IEnumerable<Appointment> FindAll() => _appointments;

        public void Add(Appointment appointment)
        {

        }

        public void Update(Appointment appointment)
        {

        }
    
    }

}
