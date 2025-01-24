using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();

        public Appointment GetById(Guid id) => _appointments.FirstOrDefault(a => a.Id == id);

        public IEnumerable<Appointment> GetAll() => _appointments;

        public void Add(Appointment appointment)
        {
           
        }

        public void Update(Appointment appointment)
        {
        
        }

        public void Delete(int id) => _appointments.RemoveAll(a => a.Id == id);
    }

}
