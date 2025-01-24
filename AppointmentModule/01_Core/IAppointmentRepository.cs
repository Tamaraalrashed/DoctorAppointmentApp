using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> FindAll();
        void Add(Appointment appointment);
        void Update(Appointment appointment);
    }
}
