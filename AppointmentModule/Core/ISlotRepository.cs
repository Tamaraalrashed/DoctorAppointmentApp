using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentModule
{
    public interface ISlotRepository
    {
        Appointment GetById(Guid id);
        IEnumerable<Slot> GetAllSlotsAvailable();
        void Update(Slot slot);
    }
}
