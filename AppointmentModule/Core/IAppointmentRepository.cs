using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    public interface IAppointmentRepository
    {
        Appointment GetById(Guid id);
        IEnumerable<Appointment> GetAll();
        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(int id);
    }
}
