using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Entities.Enums;

namespace DoctorAppointmentManagement
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> FindAll();
        void Update(Appointment  appointment);

    }
}
